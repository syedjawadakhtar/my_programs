// Problem link: https://www.hackerrank.com/challenges/lonely-integer/problem
// More about finding size of vector arrays, counting
// begin() function returns a bidirectional iterator to the first element of the container.
// end() function is used to return an iterator pointing next to last element of the vector container.
// https://www.geeksforgeeks.org/vectorbegin-vectorend-c-stl/
#include <iostream>
#include <vector>
#include <bits/stdc++.h>

using namespace std;
int lonelyinteger(vector<int> a) {
    double i; // Caused error when iterating loop
        for (i =0; i< a.size(); i++){
            if ( std::count(a.begin(), a.end(), a[i]) == 1) // std::count.. It was getting confused with something else
                return a[i];
        }
        // Better way to iterate through a vector is
        for (auto it = a.begin(); it != a.end(); it++){
            cout<< *it;
        }
    return a[i];
}