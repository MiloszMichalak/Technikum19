let i = 0;
const b = [];
document.write("<table>");
while(i < 6)
{
    a = parseInt(Math.random() * 100 + 1);
    if(b.includes(a)){
       continue;
    }
    else {
        b.push(a);
    }
    document.write("<tr><td>" + a + "</td></tr>");
    i++;
}
document.write("</table>");
