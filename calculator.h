#ifndef CALCULATOR_H
#define CALCULATOR_H

class calculator
{
    
private:
    double num1, num2;

public:
    calculator(double a = 0, double b = 0);
    void setNumbers(double a, double b);
    double add();
    double sub();
    double mul();
    double div();
};

#endif