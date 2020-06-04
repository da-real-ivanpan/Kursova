#pragma once
#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator> 
#include <sstream> 
#include <iomanip>
#include <vector>
#include <windows.h>
using namespace std;

class Country
{
private:
    string info;

public:
    string name;

    Country()
    {

    }

    Country(string a, string c)
    {
        name = a;
        info = c;
    }

    void ShowInfoCountry()
    {
        cout << "���������� ��� " << name << endl << info;
    }
};

class City
{
private: 
    string info;
public: 
    string name;
    string city;
    
    City()
    {

    }

    City(string a, string b, string c)
    {
        name = a;
        city = b;
        info = c;
    }
    void ShowInfoCity()
    {
        cout << "���������� ��� " << city << endl << info;
    }
};

class Agency
{
public:
    string AgencyName;
    string info;

    Agency()
    {

    }

    Agency(string a, string b)
    {
        this->AgencyName = a;
        this->info = b;
    }

    void ShowInfoAgency()
    {
        cout << "���������� ��� " << AgencyName << endl << info;
    }
};

class Type
{
private: 
    string info;
public:
    string name;
   
    Type()
    {

    }

    Type(string a, string b)
    {
        name = a;
        info = b;
    }

    void ShowInfoType()
    {
        cout << "���������� ��� ��� ����" << endl << info;
    }
};

//�������� ����� ��� �������
class Tours : public Agency
{
private:
    string infoTours;
public:
    string counName;
    string cityName;
    string type;
    int MonthSt;
    int MonthEnd;
    
    Tours()
    {

    }

    Tours(string a, string b, City place, string Ty, int st, int end, string infoi)
        : Agency(a, b)
    {
        this->counName = place.name;
        this->cityName = place.city;
        this->type = Ty;
        this->MonthSt = st;
        this->MonthEnd = end;
        this->infoTours = infoi;
    }

    void ShowInfoTour()
    {
        cout << "���������� ��� ���" << endl << infoTours;
    }
};