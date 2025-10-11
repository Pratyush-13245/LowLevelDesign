#include<bits/stdc++.h>
#include "calculator.h"

using namespace std;

calculator::calculator(double a, double b) : num1(a), num2(b) {}

// Set numbers
void calculator::setNumbers(double a, double b)
{
    num1 = a;
    num2 = b;
}


double calculator::add() { return num1 + num2; }
double calculator::sub() { return num1 - num2; }
double calculator::mul() { return num1 * num2; }
double calculator::div()
{
    
    if (num2 == 0)
    {
        cout << "Error: Division by zero!" << endl;
        return 0;
    }
    return num1 / num2;
}

