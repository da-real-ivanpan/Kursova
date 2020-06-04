// Kursovaya_Var_12.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Header.h"


using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Country Countries[5];
    Countries[0] = Country("Греція", "Сучасна Греція — спадкоємиця культури Стародавньої Греції і вважається колискою західної цивілізації, батьківщиною світової демократії, західної філософії основних принципів фізико-математичних наук, мистецтва театру та Олімпійських ігор сучасності. Грецька мова має найдовшу історію серед усіх мов індоєвропейської групи, адже нараховує 34 століття тільки писемного періоду. Завдяки своїй унікальній географії, Греція має низку мікрокліматичних зон з місцевими відмінностями. У північній та північно-східній частині материкової Греції,  на захід від гірського пасма Пінд, клімат вологіший і має деякі риси, типові для морського клімату. На схід від Пінду підсоння здебільшого посушливе, а погода порівняно більш вітряна.");
    Countries[1] = Country("Україна", "Гірські масиви в Україні представлені частиною Карпатських гір — Українськими Карпатами, де розташована найвища вершина України — гора Говерла (2061 м над рівнем моря), та Кримськими горами, найвищою вершиною яких є гора Роман-Кош (1545 м).");
    Countries[2] = Country("Турція", "Приваблюють туристів погодні умови узбережної частини Туреччини, де панує субтропічний середземноморський клімат, або так звані сухі субтропіки. Він характеризується доволі сухим і спекотним літом, що є надзвичайно сприятливою умовою для літнього відпочинку. У внутрішніх районах панує континентальний клімат, на сході у горах переважає гірський.");
    Countries[3] = Country("Єгипет", "Якщо Ви вибрали Єгипет для відпочинку, перед Вами відкриваються безмежні можливості, використовуйте їх усі. Єгипет – це шанс доторкнутися до історії найдавнішої цивілізації, до благ природи і всіх принад сучасного сервісу. Насолоджуйтесь курортами, пам’ятниками, морем і сонцем.");
    Countries[4] = Country("США", "Відкрийте для себе Америку. Сполучені Штати Америки можуть запропонувати безліч нового, приємного, корисного. Ви можете дізнатися цікаві факти з історії США; відвідати парки, побачити природні дива; поринути у мистецтво та архітектуру; відпочити на пляжах, спробувати наші страви й вина; насолодитися мальовничими пейзажами за вікном автомобіля, зарядитися енергією в активному відпочинку та спорті.");

    cout << "Клуб любителів туризму." << endl;
    cout << "Панасенко Іван Олегович, ІС-93, ФІОТ, АСОІУ КПІ, Київ-2020" << endl;
    //Створюємо міста
    City Cities[11];
    Cities[0] = City("Греція", "Афіни", "Lorem Ipsum");//History
    Cities[1] = City("Греція", "Маратос", "Lorem Ipsum");//Camping
    Cities[2] = City("Україна", "Копачів", "Lorem Ipsum");//Camping
    Cities[3] = City("Україна", "Кирилівка", "Lorem Ipsum");//Sea
    Cities[4] = City("Турція", "Анталія", "Lorem Ipsum");//Sea
    Cities[5] = City("Турція", "Аланія", "Lorem Ipsum");//Sea
    Cities[6] = City("Турція", "Сіде", "Lorem Ipsum");//History
    Cities[7] = City("Єгипет", "Хургада", "Lorem Ipsum");//Sea
    Cities[8] = City("Єгипет", "Каїр", "Lorem Ipsum");//History
    Cities[9] = City("Америка", "Флорида", "Lorem Ipsum");//Sea
    Cities[10] = City("Єгипет", "Шарм-ель-Шейх", "Lorem Ipsum");//Sea

    Agency agencies[3];
    agencies[0] = Agency("Histour", "Агентство Histour специфікується на історичному туризмі та часто пропонує тури до відомих історичних міст та пам'яток.");
    agencies[1] = Agency("LifeTour", "LifeTour сміливо можна назвати звичайним турагентством без певною специфікацією. У них завжди можна буде знайти тури туди, де Ви бажаєте провести вільний час і так, як Ви цього бажаєте.");
    agencies[2] = Agency("FlyBoy", "Туристичне агентство FlyBoy можна вважати молодіжним, оскільки воно специфікується на курортних місцях, які сподобаються тим, хто обожнює активний відпочинок.");

    Type types[3];
    types[0] = Type("Море", "Морський туризм пропонує Вам можливість відвідати курортні місця із теплим кліматом. Головною перлиною цих подорожей є море та її безмежні таємниці. Послуги, якими Ви можете скористатися, починаються від проведення часу у елітному готелі типу 'All Inclusive' біля побережжя моря, та доповнюються дайвінгом та прогулянками на катерах.");
    types[1] = Type("Історія", "Історичний туризм фокусується на місцевих відомих та загадкових пам'ятках. Відвідини музеїв - це не єдине, що можуть дані тури Вам запропонувати. Ви отримаєте можливість безпосередньо доторкнутися до історії на спеціальних екскурсіях.");
    types[2] = Type("Кемпінг", "Кемпінг пропонує Вам відпочинок на природі серед гір. Із наметом за спиною, Ви відвідаєте як і чудові пам'ятки природи та архітектури, так і місця з неймовірним краєвидом, який Ви навряд-чи забудете!");

    Tours Choices[6];
    //Створюємо тури
    //Tours TourA1CG1 = new Tours("Histour", Greece1, "Історія", 5, 9);
    Choices[0] = Tours(agencies[0].AgencyName, agencies[0].info, Cities[0], types[1].name, 5, 9, "Відвідайте місто Афіни - столицю Греції! ");
    //Tours TourA1CT1 = new Tours("Histour", Turkey1, "Історія", 2, 11);
    Choices[1] = Tours(agencies[1].AgencyName, agencies[1].info, Cities[2], types[2].name, 4, 10, "Маратос - гори Греції, на яких знаходяться багато церков та монастирів. Неймовірні краєвиди гарантовані.");
    Choices[2] = Tours(agencies[2].AgencyName, agencies[2].info, Cities[4], types[0].name, 3, 10, "Анталія - відоме курортне місто Турції. Турагентство допоможе Вам підібрати комфортний готель з усіма видами послуг, які Ви бажатимете.");
    Choices[3] = Tours(agencies[2].AgencyName, agencies[2].info, Cities[10], types[0].name, 3, 10, "Шарм-ель-Шейх - морський курорт Єгипта. Неймовірна морська фауна не залишить байдужим нікого!");
    Choices[4] = Tours(agencies[0].AgencyName, agencies[0].info, Cities[6], types[1].name, 1, 12, "Сіде - турецьке місто з неймовірною історією.");
    Choices[5] = Tours(agencies[0].AgencyName, agencies[0].info, Cities[8], types[1].name, 1, 12, "Каїр - столиця Єгипта, історія приховує багато таємниць про своє минуле. Розкрийте їх всі!");

    int choice = 7;
    string UserType;
    vector <string> correct_agencies;
    vector <Tours> correct_tours;
    vector <Tours> Final;

    while (choice != 0)
    {
        cout << endl << "Будь-ласка, оберіть бажану дію:" << endl;
        cout << "1. Забронювати тур;" << endl;
        cout << "2. Отримати інформацію про країну;" << endl;
        cout << "3. Отримати інформацію про тематику турів;" << endl;
        cout << "4. Отримати інформацію про тур;" << endl;
        cout << "5. Отримати інформацію про тур агентства;" << endl;
        cout << "Натисніть 0 щоб завершити роботу програми." << endl;
        cin >> choice;

        //int CountryOfChoice;
        //int TypeToChoose;
        //int TourOfChoice;
        //int AgencyOfChoice;

            switch (choice)
            {
            case 1:
            {
                cout << endl << "Який вид туру ви бажаєте? ";
                for (int i = 0; i < 3; i++)
                    cout << endl << (i + 1) << ". " << types[i].name;
                cout << endl << "Введіть номер виду туру: ";
                int TypeToChoose1;
                cin >> TypeToChoose1; cout << endl;
                if (TypeToChoose1 - 1 >= 3 || TypeToChoose1 - 1 < 0)
                {
                    cout << "Неправильно введено номер типу туру." << endl;
                    break;
                }
                UserType = types[TypeToChoose1 - 1].name;
                cout << endl << "З якого місяця ви плануєте подорож? ";
                int UserStart;
                cin >> UserStart; cout << endl;
                if (UserStart <= 0 || UserStart > 12)
                {
                    cout << endl << "Неправильно введено місяць!" << endl;
                    break;
                }
                cout << endl << "До якого місяця ви плануєте подорож? ";
                int UserEnd;
                cin >> UserEnd; cout << endl;
                if (UserEnd <= 0 || UserEnd > 12)
                {
                    cout << endl << "Неправильно введено місяць!" << endl;
                    break;
                }
                //  Додавання правильних турів в окремий стек
                for (int i = 0; i < 5; i++)
                {
                    if (UserType == Choices[i].type && ((UserStart >= Choices[i].MonthSt && UserEnd <= Choices[i].MonthEnd)))
                    {
                        correct_tours.push_back(Choices[i]);
                    }
                }
                //Додавання правильних агентств в окремий стек
                for (Tours element : correct_tours)
                {
                    int check = 0;
                    for (string name : correct_agencies)
                    {
                        if (element.AgencyName == name)
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check != 1)
                        correct_agencies.push_back(element.AgencyName);
                }
                //Створення фінального стеку

                int Count = 0;
                if (correct_tours.empty() == true)
                {
                    cout << endl << "Пробачте, жодне агентство не має пропозиції, яка може Вас задовільнити" << endl;
                    cin;
                }
                else
                {
                    cout << endl << "Варіанти, які можуть Вас задовільнити:" << endl;
                    for (string element : correct_agencies)
                    {
                        cout << endl << "Варіанти від агентства " << element << endl;
                        for (Tours tour : correct_tours)
                        {
                            if (tour.AgencyName == element)
                            {
                                Count++;
                                Final.push_back(tour);
                                cout << endl << Count << ". Тур у " << tour.cityName << ", " << tour.counName << " від " << tour.MonthSt << " і до " << tour.MonthEnd << endl;
                            }
                        }
                    }

                    cout << endl << "Введіть номер туру, який Ви хочете обрати. Або натисніть '0', щоб вийти з програми, нічого не обравши. ";
                    int input;
                    cin >> input; cout << endl;
                    if (input == 0)
                    {
                        cout << endl << "Дякуємо за користування нашими послугами!" << endl;
                        cin;
                    }
                    else
                    {
                        int temp = 0;
                        Tours FT = Final[input-1];
                        /*for (Tours element : Final)
                        {
                            if (temp != Final.size() - input)
                                temp++;
                            else
                            {
                                FT = element;
                                break;
                            }
                        }*/
                        cout << endl << "Ви обрали тур від агентства " << FT.AgencyName << " на тематику " << FT.type << " у " << FT.cityName << ", " << FT.counName << " від " << FT.MonthSt << " місяця і до " << FT.MonthEnd << " місяця." << endl;
                        cout << endl << "Дякуємо за користування нашими послугами!" << endl;
                        cin;
                    }
                }
                break;
            }
            case 2:
            {
                cout << endl << "Про яку країну Ви хочете дізнатися більше?";
                for (int i = 0; i < 5; i++)
                    cout << endl << (i + 1) << ". " << Countries[i].name;
                cout << endl << "Введіть номер країни: ";
                //int CountryOfChoice;
                int CountryOfChoice;
                cin >> CountryOfChoice; cout << endl;
                if (CountryOfChoice - 1 >= 5 || CountryOfChoice - 1 < 0)
                    cout << endl << "Неправильно введено номер країни." << endl;
                else
                    Countries[CountryOfChoice - 1].ShowInfoCountry();
                break;
            }
            case 3:
            {
                cout << endl << "Про який вид туризму Ви хочете дізнатися більше?" << endl;
                for (int i = 0; i < 3; i++)
                    cout << (i + 1) << ". " << types[i].name << endl;
                cout << endl << "Введіть номер виду туру: ";
                int TypeToChoose;
                cin >> TypeToChoose; cout << endl;
                if (TypeToChoose - 1 >= 3 || TypeToChoose - 1 < 0)
                    cout << endl << "Неправильно введено номер типу туру." << endl;
                else
                    types[TypeToChoose - 1].ShowInfoType();
                break;
            }
            case 4:
            {
                cout << endl << "Про який тур Ви хочете дізнатися більше?" << endl;
                for (int i = 0; i < 6; i++)
                    cout << (i + 1) << ". Тур у " << Choices[i].cityName << ", " << Choices[i].counName << " від " << Choices[i].MonthSt << " місяця і до " << Choices[i].MonthEnd << " місяця від агентства " << Choices[i].AgencyName << endl;
                cout << endl << "Введіть номер туру: ";
                //int check4 = 0;
                int TourOfChoice;
                cin >> TourOfChoice; cout << endl;
                if (TourOfChoice - 1 >= 6 || TourOfChoice - 1 < 0)
                    cout << endl << "Неправильно введено номер туру.";
                else
                    Choices[TourOfChoice - 1].ShowInfoTour();
                break;
            }
            case 5:
            {
                cout << endl << "Про які тур агентства Ви хочете дізнатися більше?";
                for (int i = 0; i < 3; i++)
                    cout << endl << (i + 1) << ". Тур агентство " << agencies[i].AgencyName << "." << endl;
                cout << endl << "Введіть номер тур агентства: ";
                int AgencyOfChoice;
                cin >> AgencyOfChoice; cout << endl;
                if (AgencyOfChoice - 1 >= 3 || AgencyOfChoice - 1 < 0)
                    cout << endl << "Неправильно введено номер агентства." << endl;
                else
                    agencies[AgencyOfChoice - 1].ShowInfoAgency();
                break;
            }
            case 0:
            {
                cout << endl << "Дякуємо за користування нашими послугами!";
                cin;
                break;
            }
            }
    }
}