/*Program to check the given answer on Hackerank of a given question on FILLIN IN THE MISSING LINE
with out changing the code given
The commented statements were added by me to check the working of the the code*/

#include <cmath>
#include <cstring>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    char s1[10010], s2[10010];
    cin >> s1 >> s2;
    int a[26] = {0};
    for(int i = 0; i < strlen(s1); i++) {   
        //cout<<s1[i] - 'a';  
        a[s1[i] - 'a']++;   
    }
    
    /*cout<<"\n";
    cout<<"First string done\n";
    for (int i = 0; i < sizeof(a); ++i)
    {
        cout<<a[i];    
    }*/
    
    for(int i = 0; i < strlen(s2); i++) {
       // cout<<s2[i] - 'a';
        a[s2[i] - 'a']--;
    }
    
    /*cout<<"\n";
    cout<<"Second string done\n";
    for (int i = 0; i < sizeof(a); ++i)
    {
        cout<<a[i];    
    }
    cout<<'\n';*/

    long long int ans = 0;
    for(int i = 0; i < 26; i++)
        ans+=abs(a[i]); /*FILL IN THE MISSING LINE*/
    cout << ans << endl;
    return 0;
}