/*var heightin=document.querySelector(".height");
var weightin=document.querySelector(".weight");
var result=document.querySelector(".result");
var button=document.querySelector(".button");
var statement=document.querySelector(".statement");
var height,weight,bmi;
button.addEventListener("click",()=>{
    height=heightin.value;
    weight=weightin.value;
    bmi=(weight/(height*height));
    result.innertext=bmi;
});*/
var heightIn = document.querySelector(".height-input-field");
var weightIn = document.querySelector(".weight-input-field");
var calculateButton = document.querySelector(".calculate");
var result = document.querySelector(".result");
var statement = document.querySelector(".result-statement");
var BMI, height, weight;

calculateButton.addEventListener("click", ()=>{
    
    height = heightIn.value;
    weight = weightIn.value;
    BMI = (weight/(height**2))*10000; 
    result.innerText = BMI;

    if(BMI < 18.5){
        statement.innerText = "Your BMI falls within the underweight range";    
    }else if((BMI > 18.5) && (BMI <= 24.9)){
        statement.innerText = "Your BMI falls within the normal or healthy weight range";
    }else if((BMI >= 25) && (BMI <= 29.9 )){
        statement.innerText = "Your BMI falls within the overweight range";
    }else{
        statement.innerText = "Your BMI falls within the obese range";
    }
});