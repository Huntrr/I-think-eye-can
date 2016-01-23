'use strict'; // puts us in strict mode (js in hard mode)

// gets imports
let _ = require('underscore');
let User = require('./user');
let chess = require('chess');

let mongo = require('mongodb').MongoClient;

/* This sets up a pure socket-io server.
 * Later in the guide we upgrade to a full
 * express server
// sets up the server
let Server = require('socket.io');
let io = Server(3000); //construct a server on port 3000
console.log('SocketIO listening on port 3000');
*/

// sets up express
let path = require('path');
let express = require('express');

let app = express();
app.use(express.static(path.join(__dirname, '../client')));

app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'hjs');
let routes = require('./routes');
app.use('/', routes);

// 404
app.use( (req, res, next) => {
  let err = new Error('Not found');
  err.status = 404;
  next(err);
} );
app.use( (err, req, res, next) => {
  res.status(err.status || 500);
  res.render('error', {
    errorMessage: err.message,
    error: err
  });
} );

let server = app.listen(3000, () => {
  console.log('Express server listening on port 3000');
});

let io = require('socket.io')(server);


  socket.on('MOVE', (data) => {
    let user = users[socket.id];

    let movement = {
      piece: data.piece,
      newPosition: data.position
    };


    mongo.connect(uri, function (err, db) {
        let collection = db.collection('chess');
        collection.insert({
          piece: data.piece,
          newPosition: data.position}, function(err, o) {
              if (err) { console.warn(err.message); }
        });
    });

    io.emit('MOVE', {piece, newPosition}); // broadcast the message everywhere
  });


  socket.on('CPTR', (data) => {
    let user = users[socket.id];

    let movement = {
      piece: data.piece,
      newPosition: data.position
    };

    mongo.connect(uri, function (err, db) {
        let collection = db.collection('chess');
        collection.deleteOne({
          piece: data.piece,
         }, function(err, o) {
              if (err) { console.warn(err.message); }
        });
    });

    io.emit('CPTR', piece); // broadcast the message everywhere
  });

  socket.on('RESET', (data) => {

      //reset game state

    io.emit('RESET'); // broadcast the message everywhere
  });
