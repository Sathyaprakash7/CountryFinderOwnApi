using Microsoft.EntityFrameworkCore;
using backendcountry.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CountrydbsContext>(options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conncounty"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseCors(options=>options.WithOrigins("*").AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
// h1{
//     background-color:palevioletred;
//     color:whitesmoke;
//     width:300px;
//     height:50px;
//     margin-left: 500px;
//     text-align: center;
  
  
// }

// #email{
//     padding:10px;
//     background-color:lightblue;
//     margin:30px;
//     width:250px;
//     margin-left:350px;
    
// }

// #password{
//     padding:10px;
//     background-color:lightblue;
//     margin:30px;
//     width:250px;
//     margin-left:350px;

// }

// #loginbtn{
//     background-color:black;
//     color: whitesmoke;
//     padding:10px;
//     width:100px;
//     border-radius:10px;
//     box-shadow:2px 3px 3px gray;
//     margin-left: 420px;
//     margin-top:40px;

// }

// /* #signupbtn{
//     background-color:black;
//     color: whitesmoke;
//     padding:10px;
//     width:100px;
//     border-radius:10px;
//     box-shadow:2px 3px 3px gray;
//     position: relative;
//     left:55%;
//     bottom:40px;
// } */

// img{

//     width:150px;
//     height:150px;  
//     margin-left:40% ; 
   
   
   
  
// }

// import React from "react";
// import"./Login.css";

// function Login()
// {
//     return(
//         <div classname="Mainone">

// <h1>Login</h1>
// <link rel="stylesheet" href="Login.css"/>

// <input type="text" id="email" placeholder="Enter the Email"/>
// <br/>
// <input type="text" id="password" placeholder="Enter the Password"/>
// <br/>
// <button id="loginbtn" type="submit">Login</button>
// <br/>

// <p id="signUplink">New User?<a id="a" href="Sign">Sign Up</a></p>
//         <br/>
//         <br/>
// {/* <button id="signupbtn" >SingUp</button> */}

// {/* <img src="https://dv-website.s3.amazonaws.com/uploads/2011/08/Orange-Login-Button.jpg"/> */}

// </div>
// );
// }

// export default Login;


// import React, { useState } from "react";
// import"./Register.css";

// function Register(){

//     return(
         
//         <form className="b1">
//             <div className ="sathya"> <h1>Register</h1></div>
       
//         <h2>Sign Up</h2>

//                 <input name ="Email" id="t1" type="text" placeholder="Enter Email"></input>
//                 <br/><br></br>
//                 <input name ="Username" id="t1" type="text" placeholder="Enter Username"></input>
//                 <br/><br></br>
//                 <input name ="MobileNumber" id="t1" type="text" placeholder="Enter Mobile Number"></input>
//                 <br/><br></br>
//                 <input name ="Password" id="t1" type="text" placeholder="Enter Password"></input>
//                 <br/><br></br>
//                 <input name ="Confirm" id="t1" type="text" placeholder=" Confirm Password"></input>
//                 <br/><br></br>
               
//                 <button type="submit">check Eligblity</button><br/><br/> <button>Already a user?   <a className="anchor" href='./Login.js'>Login</a></button>
//                 {/* <button id="btn1"> Submit</button>
             
//                 <button id="btn2"> Existing User?Login  </button>   */}
             
         
//         </form>
      

//     )
    
// }
// export default Register;



// *{
//     text-align: center;
//     align-items: center;
//     margin-right: auto;
//     margin-left: auto;

// }
// h1{
//     text-align: center;
//     background-color:coral;
//     opacity: 0.25px;
//     color: black;
//     width:20%;
//     height:45px;
//     border-radius: 15px;
//     margin-top: 3px;
    
// }

// .sathya{
//      position: relative;
//     opacity: 0.75;
//      top: 10px;
// }

// h2{
//     text-align: center;
//     font-style: italic;
//     color:rgb(168, 83, 83);
//     background-color: white;
//     margin-right: 60px;
//      -webkit-background-clip: text;
//      background-clip: text;
//      -webkit-text-fill-color: transparent;
//      background-image:linear-gradient(to right,black );
//      text-shadow: 1px 1px 1px #660B44;
     
// }

// #t1{
//     color: aliceblue;
//     background-color:rgb(47, 60, 60);
//     padding:10px;
//     opacity: 0.75;
//     background: linear-gradient(0.25turn, blue,white,);
// }

// ::placeholder{
//     color:white;
//     opacity: 0.75;
// }

// #btn1{
//     background-color:sandybrown;
//     opacity: 0.65;
//     color: black;
//     padding:10px;
//     width:100px;
//     border-radius:10px;
//     box-shadow:2px 3px 3px gray;
//     margin-right: 30px;
     
// }

// #btn2{
  

//     background-color:purple;
//     opacity: 0.65;
//     color:whitesmoke;
//     padding:10px;
//     width:160px;
//     border-radius:10px;
//     box-shadow:2px 3px 3px gray;
//     margin-left: 15px;

       
// }

// form{
//     position: relative;
//     background-image:url("https://thumbs.dreamstime.com/b/cook-fighting-angry-knifes-raw-chicken-attack-40174350.jpg");
//     border-radius: 13%;
//     background-size: cover;
//     width: 750px;
//     top: 20px;
//     bottom: 20px;
//     height: 550px;
//     opacity: 0.90;
     
    
// }
