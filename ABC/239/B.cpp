#include <iostream>
using namespace std;
 
int main() {
    long long x;
    cin >> x;
    
    if(x < 0 && x % 10 != 0) {
        x -= 10;
    }
    
    long long y = (long long) x / 10;
    
    cout << y << endl;
}