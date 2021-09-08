#include <iostream>
using namespace std;

void f1(int *p1) {
    cout<<(*p1)++<<endl;
    cout<<*p1<<endl; //10
}


int main() {
    int i = 10;

    f1(&i);

    return 0;
}