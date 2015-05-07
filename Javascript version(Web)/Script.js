var operators = ["+","-","*","/"];

function caller() {
    var list=[];
    document.getElementById("input").value = parser(document.getElementById("input").value,list)
}

function parser(expression ,list) {
    if (typeof(expression) === "undefined") {
      expression = document.getElementById("input").value;
    }
    
    list = [];
    var temp = "";
    var possible = [];
    var haakcount = 0;
    var prevletter = "";
    var i = 0;
    for ( i; i< expression.length; i++){
        var go = true;
        var letter = expression.charAt(i);
        switch (letter) {
            case "1":
                temp = temp.concat(letter);
                go=false;
                break;
            case "2":
                temp = temp.concat(letter);
                go=false;
                break;
            case "3":
               temp = temp.concat(letter);
               go=false;
                break;
            case "4":
                temp = temp.concat(letter);
                go=false;
                break;
            case "5":
                temp = temp.concat(letter);
                go=false;
                break;
            case "6":
                temp = temp.concat(letter);
                go=false;
                break;
            case "7":
                temp = temp.concat(letter);
                go=false;
                break;
            case "8":
                temp = temp.concat(letter);
                go=false;
                break;
            case "9":
                temp = temp.concat(letter);
                go=false;
                break;
            case "0":
                temp = temp.concat(letter);
                go=false;
                break;
            case "(":
                haakcount +=1;
                
                temp = temp.concat(letter);
                go=false;
                break;
            case ")":
                haakcount -=1;
                temp = temp.concat(letter);
                go=false;
                break;
            case ",":
                temp = temp.concat(".");
                go=false;
                break;
            case ".":
                temp = temp.concat(letter);
                go=false;
                break;
            default: 
                if (haakcount != 0) {
                    temp = temp.concat(letter);
                    go=false;
                }
                break;
         }
         if (go) {
        
         
         var thisl = letter == "+" || letter == "-" || letter == "*" || letter == "/";
         var prevl = prevletter != "+" || prevletter != "-" || prevletter != "*" || prevletter != "/";
         var b = i;
            if (haakcount == 0 && thisl && prevl && prevletter != "") {
                if (prevletter==")"){
                    var newexpr = temp.substring(1,temp.length - 1);
                    var Nlist = [];
                    list.push(parser(newexpr,Nlist).toString());
                } else {
                    list.push(temp);
                                      
                }    
                
                possible.push(letter);
                list.push(letter);
                temp = "";
                
            }
            }
        prevletter = letter;
    }
    
    if (temp != "") {
        if (prevletter == ")") {
            var newexpr = temp.substring(1,temp.length - 1);
            var Nlist = [];
            list.push(parser(newexpr,Nlist).toString());
        }
        else {
            list.push(temp);
        }    
    }
    return calculate(list,possible) ;
    
    
    
}
function calculate(list,possible) {
    if (list.length == 3) {
        
            switch (list[1]) {
                case "*":
                    return  Number(list[0])* Number(list[2]);
                case "/":
                    return  Number(list[0])/ Number(list[2]);
                case "+":
                    return  Number(list[0])+ Number(list[2]);
                case "-":
                    return  Number(list[0])- Number(list[2]);
            }
        
        
    }
    var numb = 0;
    var derp = possible.toString().indexOf("+");
    
    while (possible.toString().indexOf("*") >=0  || possible.toString().indexOf("/") >=0 )
    {
        numb = 1;
        while (numb != list.length && list.length != 1)
        {
            if (list[numb] =="*") {
                possible.splice(possible.indexOf("*"),1);
                list[numb -1] = Number(list[numb - 1]) * Number(list[numb +1]);
                list.splice(numb,2);
                numb -=2;
                
            } else if (list[numb] =="/") {
                possible.splice(possible.indexOf("/"),1);
                list[numb -1] = Number(list[numb - 1]) / Number(list[numb +1]);
                list.splice(numb,2);
                numb -=2;
            }
            
            numb +=2;
            
        }
        
        
    }
    while (possible.toString().indexOf("+")>=0 || possible.toString().indexOf("-")>=0)
    {
        numb = 1;
        while (numb != list.length && list.length != 1)
        {
            if (list[numb] =="+") {
                possible.splice(possible.indexOf("+"),1);
                list[numb -1] = Number(list[numb - 1]) + Number(list[numb +1]);
                list.splice(numb,2);
                numb -=2;
                
            } else if (list[numb] =="-") {
                possible.splice(possible.indexOf("-"),1);
                list[numb -1] = Number(list[numb - 1]) - Number(list[numb +1]);
                list.splice(numb,2);
                numb -=2;
            }
            
            numb +=2;
            
        }
        
        
    }
    
    
    
    return Number(list[0]);
    //code
}

