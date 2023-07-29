// C++ program to calculate the denomincations of a given currency
// Use of maps in C++ (Dictionaries)

#include <iostream>
#include <map>
#include <iterator>

using namespace std;

auto denomination(int currency) {
    int temp = currency;
    map<int, int> curr;
    curr[1] = 0;
    curr[5] = 0;
    curr[10] = 0;
    curr[50] = 0;
    curr[100] = 0;
    do {
        if (temp / 100) {
            curr[100] = temp / 100;
            temp = temp % 100;
        }
        else if (temp / 50) {
            curr[50] = temp / 50;
            temp = temp % 50;
        }
        else if (temp / 10) {
            curr[10] = temp / 10;
            temp = temp % 10;
        }
        else if (temp / 5) {
            curr[5] = temp / 5;
            temp = temp % 5;
        }
        else if (temp / 1) {
            curr[1] = temp / 1;
            temp = temp % 1;
        }
    } while (temp != 0);

    return curr;
}

int main() {
    int currency;
    cout << "Enter the currency value in integers: ";
    cin >> currency;
    std::map<int, int> result = denomination(currency);
    cout << "The denomination of currencies are: " << endl;

    map<int, int>::iterator it = result.begin();

    // Iterate through the map and print the elements
    while (it != result.end())
    {
        cout << it->first << ":" << it->second << endl;
        ++it;
    }

    return 0;
}