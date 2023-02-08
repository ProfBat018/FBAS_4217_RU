#include <iostream>

using namespace std;

class number
{
public:

	number operator+(number other)
	{
		number res;
		res.value = this->value + other.value;
		return res;
	}


	// возвращаемый_тип operator+(параметры)
	// тело 

	int value;
};

class person
{
public:
	string name;
	string surname;
	int age;

	bool operator>(person other)
	{
		return this->age > other.age;
	}

	bool operator<(person other)
	{
		return this->age < other.age;
	}
};

int main()
{
	// number n1;
	// number n2;
	//
	// n1.value = 10;
	// n2.value = 20;
	//
	// // number  n3 = n1 + n2;
	//
	// number n3 = n1.operator+(n2);
	//
	// cout << n3.value;


	person p1;
	person p2;

	p1.age = 18;
	p2.age = 20;

	cout << (p1 > p2);

	return 0;
}
