console.log("Welcome!!");

// var , let ,const


// function abc( x,  y)
// {
//     return x+y;
// }

// let ans=abc(10,"ggg")

//STRING
let myName:string="raja";
console.log(myName);
console.log(myName.toUpperCase());

//NUMBER
let userId: number=44;
console.log(userId);

//--------------------------------------------------------------

//FUNCTIONS-->RETURN TYPE WITHOUT PARAMETER

//RETURN TYPE WITH STRING
function gamename():string{
    return "godofwar";   
}
let game:string=gamename();
console.log(game);

//RETURN TYPE WITH NUMBER
function gamesize():number
{
    return 24;
}
let gsize:number=gamesize();
console.log(gsize);

//-------------------------------------------------------------

//FUNTIONS WITH PARAMETER

function detail(name4:string):string{
    console.log(name4);
    return "hello!";
}
let say=detail("hell");

console.log(say);


function detail2(name3:string , email:string, no:number):void{
    console.log("His name is "+name3+" with mail id as "+email+" and is ph no is "+no);
}
detail2("Rajnesh","twinbroz16@gmail.com",9150112752);

//----------------------------------------------------------------------------

//MAP FUNCTION
//TYPE-1
let arr1=[1,2,3,4,5];
let ans=arr1.map(function(val){
    return val*5;
})
console.log(ans);
//TYPE-2
let arr2=[
    {id:1,firstname:"Raja ",lastname:"Durai"},
    {id:2,firstname:"Rajnesh ",lastname:"Durai"},
    {id:3,firstname:"Rajeesh ",lastname:"Durai"},
]
let ans2=arr2.map(function(val){
    let fullName= val.firstname+val.lastname;
    return [fullName];
})
console.log(ans2);

//-------------------------------------------------------------------------

//USE OF VOID=>WHEN WE DONT RETURN ANYTHING IN A FUNCTION BUT WE PRINT INSIDE IT

function errmsg(err:string):void{
    console.log(err);
}
errmsg("Incorrect");

//USE OF NEVER=> WE USE WHEN WE HANDLE ERROR=> TYPESCRIPT DOCUMENTATION

function handleError(msg:string):never{
    throw new Error(msg);
}


//-------------------------------------------------------------------

function f1(x:string | number){
    if(typeof x=== "string")
    {
        return "s";
    }
    else{
        return 1;
    }
}
let a=f1("game");
console.log(a);
let b=f1(6);
console.log(b);

//----------------------------------------------------------

//OBJECTS IN FUNCTION
function creater():{name:string,id:boolean}
{
   return {name:"RAJA",id:true};
}
let cam=creater();
console.log(cam);

function f2(pt:{n1:number,n2:number}){
    return pt.n1+pt.n2;
}
let ans4:number=f2({n1:10,n2:20});
console.log(ans4);

//-----------------------------------------------------------

//TYPE ALIAS 
type User={
    name:string,
    age:number,
    addr:string
};
function typer(use:User){
    console.log(use.name);
    console.log(use.age);
}
typer({name:"Raja" ,age:10,addr:"ahjhdb"});

//PRACTISE IN OBJECT AND TYPE-ALIAS 
function f4(pt:{n3:number,n4:number}):number
{
    return pt.n3+pt.n4;
}
let sum=f4({n3:10,n4:69});
console.log(sum);

type myDetail={
    name2:string,
    dob:number,
    batch:number
}
function f8(pt3:{name2:string,dob:number,batch:number})
{
    console.log("My name is "+pt3.name2+" and by dob is in "+pt3.dob+" and " +pt3.batch+" is my batch")
}
let sum2=f8({name2:"Raja",dob:2001,batch:2023})

//FUNCTIONS 
//type-1
function a1(arg1:number):number{
    return 50-arg1;
}
let k=a1(9);
console.log(k);
//type-2
let a2=function(arg2:number):number{
    return 80-arg2;
}
let h=a2(35);
console.log(h);
//type-3:arrow fn

/*let a3=arg3=>80-arg3;
let j=a3(40);*/

class person{
    greet():number{
        return  45;
    }
}
let p=new person();
p.greet();

//SYNTAX FOR CLASS
class list{
     name3:string;
    constructor(name3:string){
        this.name3=name3;
        console.log(this.name3);
    }
    greetMethod():number{
        console.log("welcome "+this.name3);
        return 78
    }
}
let l=new list("RAJA")
console.log(l.greetMethod());

class PersonDetails2
{
    age7: number;
    name7: string;
    constructor(name:string,age:number)
    {
        this.name7=name;
        this.age7=age;
        console.log(this.name7 +" and his age is "+this.age7)
    }
    greetMethod()
    {
        console.log("In greet statement")
    }
}
let persons=new PersonDetails2("Raja",56);
persons.greetMethod()

//inheritance in cls
class A
{
    constructor(name:string)
    {
        console.log(name);
    }
    getid():number
    {
        return 4;
    }
}
class B extends A
{
    constructor(name:string){
        super(name);
        console.log(name+".............................")
    }
    getid(): number {
        {
            return super.getid();
        }
    }
}
let clsB=new B("Rajnesh")
let pr=clsB.getid()
console.log(pr)


//--------------------------------------------------------

//SET

let mySet= new Set();
mySet.add("hi")
mySet.add(1)
console.log(mySet.size);

let myNew = new Set([1,2,6,9,4,4,6,0])
console.log(myNew.size);


//MAP

let myMap= new Map()
myMap.set("fname","Raja")
myMap.set("age",45)
let ob1={};
let ob2={}

myMap.set(ob1,81)

console.log(myMap.get("age"));
console.log(myMap.get("ob1"));
console.log(myMap.size);

//--------------------------

function ax(ac){
    return ac+5
}
console.log(ax(6))

let ag=(ad)=>{
    return ad+9
}
console.log(ag(6))
