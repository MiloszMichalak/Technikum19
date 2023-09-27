// Czesc teoretyczna


int reku1(int n)
{
//oblicz dla 5 12 16 21 75
int w;
if (n==1) return 1;
w = reku1(n/2);
if (n%2==0) w = w * 2;
else w = w * 3;
return w;
}

int reku2(int n)
{
//oblicz dla 5 7 8 11
int w;
if (n==3) return 1;
w = reku2(n-1);
if (n%2==1) w++;
else w = w * 2;
return w;
}


int reku3(int n)
{
//oblicz dla 4 5 7 11
int w;
if (n==1) return 0;
w = reku3(n-1);
if (n%3==0) w++;
if (n%3==1) w = w + 2;
if (n%3==2) w = w * 3;
return w;
}


int reku4(int n)
{
//oblicz dla 9 13
int w;
if (n==1) return 0;
w = reku4((n-1)*2-n);
if (n%2==1) w++;
if (n%3>0) w = w + 2;
return w;
}

