// factorial.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <process.h>
int fact(int);

int main()
{
    int num, f, check;
    loop:
    std::cout << "Enter a number:";
    std::cin >> num;
    f = fact(num);
    std::cout << "\nFactorial of " << num << " is " << f;
    std::cout << "\n Want to check for more numbers ? (press -1)";
    std::cin >> check;
    if (check == -1)
        goto loop;
    else
        exit(0);
    return 0;
}

int fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    else
        return (n * fact(n - 1));
    return n;
}
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
