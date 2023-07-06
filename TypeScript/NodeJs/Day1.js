var http= require('http');
var today=require('./Day1DateTime')


http.createServer(function(req,res)
{
    // res.writeHead(500,{'Content-Type':'text/html'})   
    // res.write('Hello World\n')

    res.write(today.mydateTime())
    res.end('Done')
}).listen(8000);