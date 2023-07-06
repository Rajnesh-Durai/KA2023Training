//EVENT ON READ
//CREATE A TEXT FILE BEFORE HAND
var http= require('http')
var fileobj =require('fs')
var events= require('events')


http.createServer(function(req,res)
{
    // var readstream=fileobj.createReadStream('./fileinurl.js')

    // readstream.on('open',function()
    // {
    //     console.log('File is Opened!!')
    // });

    //EVENT HANDLER & EVENT EMITTER

    //CREATE A EVENT HANDLER
    var myEventHandler=function()
    {
        console.log('I scored 100')
    }

    var eventEmitter= new events.EventEmitter()

    //Assign event Handler
    eventEmitter.on('Results out',myEventHandler)


    eventEmitter.emit('Results out')


}).listen(8080);
