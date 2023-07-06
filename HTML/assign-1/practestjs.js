function validateName()
{
    /*let name=document.getElementById("name");
    let ncheck=/^[A-Za-z\s]*$/;
    if(name.value="" || !name.value.match(ncheck))
    {
        document.getElementById("result").innerHTML="Please enter valid Credentials"; 
    }*/
  var entered_name = document.getElementById("name");
  var regName = /^[A-Za-z\s]*$/;
  if (entered_name.value == "" || !entered_name.value.match(regName)) {
    entered_name.classList.remove("valid");
    entered_name.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_name.focus();
  } else {
    entered_name.classList.remove("invalid");
    entered_name.classList.add("valid");
  }
}

function validateNum()
{
    var re = /^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{4})$/;
  var entered_phnumber = document.getElementById("num");
  if (entered_phnumber.value.match(re)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    entered_phnumber.classList.remove("valid");
    entered_phnumber.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_phnumber.focus();
  }
}

function validateMail()
{
    var entered_email = document.getElementById("mail");
  var validRegex =
    /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
  if (entered_email.value.match(validRegex)) {
    entered_email.classList.remove("invalid");
    entered_email.classList.add("valid");
  } else {
    entered_email.classList.remove("valid");
    entered_email.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_email.focus();
  }
}

function validateAdd()
{
    var entered_address = document.getElementById("addr");
  if (entered_address.value == "") {
    entered_address.classList.remove("valid");
    entered_address.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_address.focus();
  } else {
    entered_address.classList.remove("invalid");
    entered_address.classList.add("valid");
  }
}

let combo={
    option1:799,
    option2:899,
    option3:1199,
    option4:299,
    option5:999,
}
function calculate()
{
    let opt1=document.getElementById("option1").checked;
    let opt2=document.getElementById("option2").checked;
    let opt3=document.getElementById("option3").checked;
    let opt4=document.getElementById("option4").checked;
    let opt5=document.getElementById("option5").checked;
    let total=0;

    if((opt1) || (opt2) || (opt3) || (opt4) || (opt5))
    {
        if(opt1)
        {
            total+=combo.option1;
        }
        if(opt2)
        {
            total+=combo.option2;
        }
        if(opt3)
        {
            total+=combo.option3;
        }
        if(opt4)
        {
            total+=combo.option4;
        }
        if(opt5)
        {
            total+=combo.option5;
        }
        if(total>=2000)
        {
            let amt=(total*20)/100;
            let famt=total-amt;
            document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
            Math.round(famt) +
            " on delivery.";
        }
        else{
            document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
            Math.round(total) +
            " on delivery.";
        }
    }
    else{
        document.getElementById("result").innerHTML = "No selection has been made.";
    }
}