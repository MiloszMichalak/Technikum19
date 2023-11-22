let i = 1, a;
const b = [];
document.write("<table>");
do{
    a = parseInt(Math.random() * 100 + 1);
    if(b.includes(a)){
       continue;
    }
    else {
        b.push(a);
    }
    document.write("<tr><td>"+a+"</td></tr>");
    i++;
} while (i <= 6);
document.write("</table>");
