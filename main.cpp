#include<bits/stdc++.h>
#include "calculator.h"

using namespace std;


int main()
{
    
    calculator calc;
    double a, b;
    cout << "Enter two numbers: ";
    cin >> a >> b;

    calc.setNumbers(a, b);

    cout << "Sum: " << calc.add() << endl;
    cout << "Difference: " << calc.sub() << endl;
    cout << "Product: " << calc.mul() << endl;
    cout << "Division: " << calc.div() << endl;

    return 0;

    
}