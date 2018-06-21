// Write your JavaScript code.
$(document).ready(function() {
    
    
    
    $("#Phonenumber").on('keyup', function(event) {
        console.log(event.keyCode);
        console.log($("#Phonenumber").val());
        console.log($("#Phonenumber").val().length);
        if(event.keyCode >= 48 && event.keyCode<=57) {
            console.log("Eingabe war eine Zahl");
        } else {
            
            var inputValue = $("#Phonenumber").val();
            console.log("Eingabe war keine Zahl");
            console.log($("#Phonenumber").val());
            $("#Phonenumber").val(inputValue.substring(0,inputValue.length-1));


        }
    });
});

function phonenumber(inputtxt)
{
  var phoneno = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;
  console.log(inputtxt);
  if(inputtxt.match(phoneno))
     {
	   return true;      
	 }
   else
     {
	   alert("Not a valid Phone Number");
	   return false;
     }
}