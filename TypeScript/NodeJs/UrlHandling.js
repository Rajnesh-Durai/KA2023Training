var http  = require('http')
var url = require('url')

http.createServer(function(req,res)
{
    res.writeHead(200,{'Content-Type':'text/html'})
    res.write(req.url)
    // var querystr=url.parse(req.url, true).query
    // var value= querystr.UN + querystr.PWD
    // res.write(value)

    var adr='http://localhost:8080/default.htm?year=2023&month=May';
    var querystr=url.parse(adr,true)
    console.log(querystr.host) //returns localhost 8080
    console.log(querystr.pathname) // returns '/default.htm'
    console.log(querystr.search) //returns '?year=2023&month=May'

    var querydata=querystr.query // after?
    console.log(querydata)
    console.log(querydata.month) //returns May


    res.end()
}
).listen(8080);