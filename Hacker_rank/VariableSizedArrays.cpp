#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    vector<vector<int>> TwoDArray;
    int n, q, l, m, p;
    cin >> n >> q;      // size of array a; no. of rows
    for (int i=0; i<n; i++){
        int x;
        cin >> x;   // No of elements in the sub array; no of columns in that row
        vector<int> row;            
        for (int j = 0; j<x; j++){
            cin>> p;    // inserting elements in that row
            row.push_back(p);
        }
        TwoDArray.push_back(row);
    }
    // Print element j at array a[i]
    for (int i = 0; i<q; i++){
        cin>> l >> m;
        cout << TwoDArray[l][m] << "\n";
    }
    return 0;
}
