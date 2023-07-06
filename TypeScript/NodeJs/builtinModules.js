var http= require('http')
http.createServer(function(req,res)
{
    //CONFIGURE EMAIL
var nodemailer = require('nodemailer');

var transporter = nodemailer.createTransport(
{
    service: 'gmail',
    auth: {
        user: 'rajarajnesh16@gmail.com',
        pass: 'dtfe tyrp nyxq fbqg'
    }
}
);

    var mailOptions =
    {
        from: 'rajarajnesj16@gmail.com',
        to: 'twinbroz16@gmail.com',        //add more comma separated receipients 
        subject: 'Sending Email using Node.js',
        text: 'That was easy!'                   // html: '<h1>Welcome</h1><p>That was easy!</p>'
    };

    transporter.sendMail(mailOptions, function (error, info)
    {
        if (error) {
            console.log(error);
        } else {
            console.log('Email sent: ' + info.response);
        }
    });
}).listen(8080);
