

 console.log("hello");
 function ans(name:string)
 {
    var output;
    if(name==="Raja")
    {
        output=name;
    }
    else
    {
        output="incorrect";
    }
    console.log(output);
 }
 ans("Raja");

//let ==> FOR

//  for(let i:number=0;i<5;i++)
//  {
//     setTimeout(function(){console.log(i)},5000);
//  }

const fun1= function(){
    return 25;
}
console.log(fun1())

const fun2=()=> 19;
console.log(fun2())


//object and this keyword

const obj1={
    name:'Raja',
    fun3:function(){
        setTimeout(()=>{ console.log(this.name)},1000) 
    }
}
obj1.fun3();