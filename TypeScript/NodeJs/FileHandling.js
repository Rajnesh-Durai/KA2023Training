var http = require('http')
var fileObj= require('fs')

http.createServer(function(req,res)
{
    //CREATE FILE IN WRITE MODE

    // fileObj.open('sample1.txt','w',function(err,file)
    // {
    //     if(err) throw err;
    //     console.log('Saved!')
    // });

    //WRITING INSIDE THE CREATED FILE

    // fileObj.writeFile('sample1.txt','Hello EveryOne!!',function(err)
    // {
    //     if(err) throw err;
    //     console.log('Written!')
    // });

    //READ FILE

    fileObj.readFile('SampleTry.html',function(err,data)
    {
        res.writeHead(200,{'Content-Type':'text/html'})
        res.write(data)
        console.log(data)
        return res.end()
    });

    //APPEND FILE

    // fileObj.appendFile('sample1.txt','Raja Rajnesh Rajeesh Laaxmeesh',function(err)
    // {
    //     if(err) throw err;
    //     console.log('Appended!')
    // })

    //RENAMING A FILE

    // fileObj.rename('sample1.txt','JustCreated.txt',function(err)
    // {
    //     if(err) throw err;
    //     console.log('Renamed!')
    // })

    //DELETING A FILE

    // fileObj.unlink('JustCreated.txt',function(err)
    // {
    //     if(err) throw err;
    //     console.log('Deleted!')
    // })


}).listen(8080);