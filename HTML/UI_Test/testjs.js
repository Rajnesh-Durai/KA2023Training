function validateName()
{
  var entered_name = document.getElementById("name");
  var regName = /^[A-Za-z\s]*$/g;
  if (entered_name.value == "" || !entered_name.value.match(regName)) {
    alert("Invalid Customer Name")
  } else {
    entered_name.classList.remove("invalid");
    entered_name.classList.add("valid");
  }
}
function validateNum()
{
  var re = /[789]{1}[0-9]{9}/g;
  var entered_phnumber = document.getElementById("num");
  if (entered_phnumber.value.match(re)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    alert("Invalid Phone Number");
  }
}
function validateAadhar()
{
  var addh = /[1-9]{12}/g;
  var entered_phnumber = document.getElementById("aadhar");
  if (entered_phnumber.value.match(addh)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    alert("Invalid Aadhar Number");
  }
}
function validateCard()
{
    var re = /[0-9]{16}/g;
  var entered_phnumber = document.getElementById("cardNumber");
  if (entered_phnumber.value.match(re)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    alert("Invalid Card Number");
}
}
function validateccv()
{
    var re = /[0-9]{3}/g;
  var entered_phnumber = document.getElementById("cvvNumber");
  if (entered_phnumber.value.match(re)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    alert("Invalid CCV Number");
}}

function calculate1()
{   
    let adultc=Number(document.getElementById("adult").value);
    var childc=Number(document.getElementById("child").value);
    var total=adultc+childc;

    var date=document.getElementById("date").value;
    var opt=document.getElementById("package").value;
    var package1=11000;
    var package2=20000;
    var package3=29000;
    var package4=38000;
    var package5=47000;
    var num,amt,i;

if(opt==package1)
    {
    var num=2;
    var amt=11000;
    if(total>num)
    {
        num=total-num;
        for( var i=0;i<num;i++)
        {
            amt+=3000;
        }
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
    else{
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
}
if(opt==package2)
{
    var num=3;
    var amt=20000;
    if(total>num)
    {
        num=total-num;
        for( var i=0;i<num;i++)
        {
            amt+=3500;
        }
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
    else{
        document.getElementById("result").innerHTML=="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }

}
if(opt==package3)
{
    var num=3;
    var amt=29000;
    if(total>num)
    {
        num=total-num;
        for( var i=0;i<num;i++)
        {
            amt+=3500;
        }
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
    else{
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }

}
if(opt==package4)
{
    var num=4;
    var amt=38000;
    if(total>num)
    {
        num=total-num;
        for( var i=0;i<num;i++)
        {
            amt+=4000;
        }
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
    else{
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }

}
if(opt==package5)
{
    var num=4;
    var amt=47000;
    if(total>num)
    {
        num=total-num;
        for( var i=0;i<num;i++)
        {
            amt+=4000;
        }
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }
    else{
        document.getElementById("result").innerHTML="Total amount Rs."+amt+" is paid successfully.Your Booking is Confirmed.Your Check-in Date is"+date;
    }

}
}

