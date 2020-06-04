using System;
using System.Collections;

namespace Kursovaya_var_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Country[] Countries = new Country[5];
            Countries[0] = new Country("Греція", "Сучасна Греція — спадкоємиця культури Стародавньої Греції " +
                "і вважається колискою західної цивілізації, батьківщиною світової демократії, західної філософії," +
                " основних принципів фізико-математичних наук, мистецтва театру та Олімпійських ігор сучасності." +
                " Грецька мова має найдовшу історію серед усіх мов індоєвропейської групи," +
                " адже нараховує 34 століття тільки писемного періоду. Завдяки своїй унікальній географії, " +
                "Греція має низку мікрокліматичних зон з місцевими відмінностями. У північній та північно-східній частині материкової Греції, " +
                "на захід від гірського пасма Пінд, клімат вологіший і має деякі риси, типові для морського клімату." +
                " На схід від Пінду підсоння здебільшого посушливе, а погода порівняно більш вітряна.");
            Countries[1] = new Country("Україна", "Гірські масиви в Україні представлені частиною Карпатських гір" +
                " — Українськими Карпатами, де розташована найвища вершина України —" +
                " гора Говерла (2061 м над рівнем моря), та Кримськими горами, найвищою вершиною яких є" +
                " гора Роман-Кош (1545 м).");
            Countries[2] = new Country("Турція", "Приваблюють туристів погодні умови узбережної частини Туреччини, " +
                "де панує субтропічний середземноморський клімат, або так звані сухі субтропіки. Він характеризується доволі " +
                "сухим і спекотним літом, що є надзвичайно сприятливою умовою для літнього відпочинку. У внутрішніх районах " +
                "панує континентальний клімат, на сході у горах переважає гірський.");
            Countries[3] = new Country("Єгипет", "Якщо Ви вибрали Єгипет для відпочинку, перед Вами відкриваються безмежні " +
                "можливості, використовуйте їх усі. Єгипет – це шанс доторкнутися до історії найдавнішої цивілізації, " +
                "до благ природи і всіх принад сучасного сервісу. Насолоджуйтесь курортами, пам’ятниками, морем і сонцем.");
            Countries[4] = new Country("США", "Відкрийте для себе Америку. Сполучені Штати Америки можуть запропонувати безліч нового, приємного, корисного. Ви можете дізнатися цікаві факти з історії США; відвідати парки, побачити природні дива; поринути у мистецтво та архітектуру; " +
                "відпочити на пляжах, спробувати наші страви й вина; насолодитися мальовничими пейзажами за вікном автомобіля, зарядитися енергією в активному відпочинку та спорті.");

            Console.WriteLine("Клуб любителів туризму.");
            Console.WriteLine("Панасенко Іван Олегович, ІС-93, ФІОТ, АСОІУ КПІ, Київ-2020");
            //Створюємо міста
            City[] Cities = new City[11];
            Cities[0] = new City("Греція", "Афіни", "Lorem Ipsum");//History
            Cities[1] = new City("Греція", "Маратос", "Lorem Ipsum");//Camping
            Cities[2] = new City("Україна", "Копачів", "Lorem Ipsum");//Camping
            Cities[3] = new City("Україна", "Кирилівка", "Lorem Ipsum");//Sea
            Cities[4] = new City("Турція", "Анталія", "Lorem Ipsum");//Sea
            Cities[5] = new City("Турція", "Аланія", "Lorem Ipsum");//Sea
            Cities[6] = new City("Турція", "Сіде", "Lorem Ipsum");//History
            Cities[7] = new City("Єгипет", "Хургада", "Lorem Ipsum");//Sea
            Cities[8] = new City("Єгипет", "Каїр", "Lorem Ipsum");//History
            Cities[9] = new City("Америка", "Флорида", "Lorem Ipsum");//Sea
            Cities[10] = new City("Єгипет", "Шарм-ель-Шейх", "Lorem Ipsum");//Sea

            Agency[] agencies = new Agency[3];
            agencies[0] = new Agency("Histour", "Агентство Histour специфікується на історичному туризмі та часто пропонує тури до відомих історичних міст та пам'яток.");
            agencies[1] = new Agency("LifeTour", "LifeTour сміливо можна назвати звичайним турагентством без певною специфікацією. У них завжди можна буде знайти тури туди, де Ви бажаєте провести вільний час і так, як Ви цього бажаєте.");
            agencies[2] = new Agency("FlyBoy", "Туристичне агентство FlyBoy можна вважати молодіжним, оскільки воно специфікується на курортних місцях, які сподобаються тим, хто обожнює активний відпочинок.");

            Type[] types = new Type[3];
            types[0] = new Type("Море", "Морський туризм пропонує Вам можливість відвідати курортні місця із теплим кліматом. Головною перлиною цих подорожей є море та її безмежні таємниці. Послуги, якими Ви можете скористатися," +
                " починаються від проведення часу у елітному готелі типу 'All Inclusive' біля побережжя моря, та доповнюються дайвінгом та прогулянками на катерах.");
            types[1] = new Type("Історія", "Історичний туризм фокусується на місцевих відомих та загадкових пам'ятках. Відвідини музеїв - це не єдине, що можуть дані тури Вам запропонувати. Ви отримаєте можливість безпосередньо " +
                "доторкнутися до історії на спеціальних екскурсіях.");
            types[2] = new Type("Кемпінг", "Кемпінг пропонує Вам відпочинок на природі серед гір. Із наметом за спиною, Ви відвідаєте як і чудові пам'ятки природи та архітектури, так і місця з неймовірним краєвидом, який Ви навряд-чи забудете!");
            
            Tours[] Choices = new Tours[6];
            //Створюємо тури
            //Tours TourA1CG1 = new Tours("Histour", Greece1, "Історія", 5, 9);
            Choices[0] = new Tours(agencies[0].AgencyName, agencies[0].info, Cities[0], types[1].name, 5, 9, "Відвідайте місто Афіни - столицю Греції! ");
            //Tours TourA1CT1 = new Tours("Histour", Turkey1, "Історія", 2, 11);
            Choices[1] = new Tours(agencies[1].AgencyName, agencies[1].info, Cities[2], types[2].name, 4, 10, "Маратос - гори Греції, на яких знаходяться багато церков та монастирів. Неймовірні краєвиди гарантовані.");
            Choices[2] = new Tours(agencies[2].AgencyName, agencies[2].info, Cities[4], types[0].name, 3, 10, "Анталія - відоме курортне місто Турції. Турагентство допоможе Вам підібрати комфортний готель з усіма видами послуг, які Ви бажатимете.");
            Choices[3] = new Tours(agencies[2].AgencyName, agencies[2].info, Cities[10], types[0].name, 3, 10, "Шарм-ель-Шейх - морський курорт Єгипта. Неймовірна морська фауна не залишить байдужим нікого!");
            Choices[4] = new Tours(agencies[0].AgencyName, agencies[0].info, Cities[6], types[1].name, 1, 12, "Сіде - турецьке місто з неймовірною історією.");
            Choices[5] = new Tours(agencies[0].AgencyName, agencies[0].info, Cities[8], types[1].name, 1, 12, "Каїр - столиця Єгипта, історія приховує багато таємниць про своє минуле. Розкрийте їх всі!");

            int choice = 7;
            while (choice != 0)
            {
                Console.WriteLine("Будь-ласка, оберіть бажану дію:");
                Console.WriteLine("1. Забронювати тур;");
                Console.WriteLine("2. Отримати інформацію про країну;");
                Console.WriteLine("3. Отримати інформацію про тематику турів;");
                Console.WriteLine("4. Отримати інформацію про тур;");
                Console.WriteLine("5. Отримати інформацію про тур агентства;");
                Console.WriteLine("Натисніть 0 щоб завершити роботу програми.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Який вид туру ви бажаєте? ");
                        for (int i = 0; i < types.Length; i++)
                            Console.WriteLine((i + 1) + ". " + types[i].name);
                        Console.Write("Введіть номер виду туру: ");
                        int TypeToChoose1 = Convert.ToInt32(Console.ReadLine());
                        if (TypeToChoose1 - 1 >= types.Length || TypeToChoose1 - 1 < 0)
                        {
                            Console.WriteLine("Неправильно введено номер типу туру.");
                            break;
                        }
                        string UserType = types[TypeToChoose1 - 1].name;
                        Console.Write("З якого місяця ви плануєте подорож? ");
                        int UserStart = Convert.ToInt32(Console.ReadLine());
                        if (UserStart <= 0 || UserStart > 12)
                        {
                            Console.WriteLine("Неправильно введено місяць!");
                            break;
                        }
                        Console.Write("До якого місяця ви плануєте подорож? ");
                        int UserEnd = Convert.ToInt32(Console.ReadLine());
                        if (UserEnd <= 0 || UserEnd > 12)
                        {
                            Console.WriteLine("Неправильно введено місяць!");
                            break;
                        }
                        //  Додавання правильних турів в окремий стек
                        Stack correct_tours = new Stack();
                        for (int i = 0; i < Choices.Length; i++)
                        {
                            if (UserType == Choices[i].type && ((UserStart >= Choices[i].MonthSt && UserEnd <= Choices[i].MonthEnd)))
                            {
                                int check = 0;
                                foreach (Tours element in correct_tours)
                                {
                                    if (element == Choices[i])
                                    {
                                        check = 1;
                                        break;
                                    }
                                }
                                if (check != 1)
                                    correct_tours.Push(Choices[i]);
                            }
                        }
                        //Додавання правильних агентств в окремий стек
                        Stack correct_agencies = new Stack();
                        foreach (Tours element in correct_tours)
                        {
                            int check = 0;
                            foreach (string name in correct_agencies)
                            {
                                if (element.AgencyName == name)
                                {
                                    check = 1;
                                    break;
                                }
                            }
                            if (check != 1)
                                correct_agencies.Push(element.AgencyName);
                        }
                        //Створення фінального стеку
                        Stack Final = new Stack();
                        int Count = 0;
                        if (correct_tours.Count == 0)
                        {
                            Console.WriteLine("Пробачте, жодне агентство не має пропозиції, яка може Вас задовільнити");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Варіанти, які можуть Вас задовільнити:");
                            foreach (string element in correct_agencies)
                            {
                                Console.WriteLine("Варіанти від агентства " + element);
                                foreach (Tours tour in correct_tours)
                                {
                                    if (tour.AgencyName == element)
                                    {
                                        Count++;
                                        Final.Push(tour);
                                        Console.WriteLine(Count + ". Тур у " + tour.cityName + ", " + tour.counName + " від " + tour.MonthSt + " і до " + tour.MonthEnd);
                                    }
                                }
                            }
                            Console.Write("Введіть номер туру, який Ви хочете обрати. Або натисніть '0', щоб вийти з програми, нічого не обравши. ");
                            int input = Convert.ToInt32(Console.ReadLine());
                            if (input == 0)
                            {
                                Console.WriteLine("Дякуємо за користування нашими послугами!");
                                Console.ReadLine();
                            }
                            else
                            {
                                int temp = 0;
                                Tours FT = null;
                                foreach (Tours element in Final)
                                {
                                    if (temp != Final.Count - input)
                                        temp++;
                                    else
                                    {
                                        FT = element;
                                        break;
                                    }
                                }
                                Console.WriteLine("Ви обрали тур від агентства " + FT.AgencyName + " на тематику " + FT.type + " у " + FT.cityName + ", " + FT.counName + " від " + FT.MonthSt + " місяця і до " + FT.MonthEnd + " місяця.");
                                Console.WriteLine("Дякуємо за користування нашими послугами!");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Про яку країну Ви хочете дізнатися більше?");
                        for (int i = 0; i<Countries.Length; i++)
                            Console.WriteLine((i + 1) + ". " + Countries[i].name);
                        Console.Write("Введіть номер країни: ");
                        int CountryOfChoice = Convert.ToInt32(Console.ReadLine());
                        if (CountryOfChoice - 1 >= Countries.Length || CountryOfChoice - 1 < 0)
                            Console.WriteLine("Неправильно введено номер країни.");
                        else
                            Countries[CountryOfChoice - 1].ShowInfoCountry();
                            break;
                    case 3:
                        Console.WriteLine("Про який вид туризму Ви хочете дізнатися більше?");
                        for (int i = 0; i < types.Length; i++)
                            Console.WriteLine((i + 1) + ". " + types[i].name);
                        Console.Write("Введіть номер виду туру: ");
                        int TypeToChoose = Convert.ToInt32(Console.ReadLine());
                        if (TypeToChoose - 1 >= types.Length || TypeToChoose - 1 < 0)
                            Console.WriteLine("Неправильно введено номер типу туру.");
                        else
                            types[TypeToChoose - 1].ShowInfoType();
                        break;
                    case 4:
                        Console.WriteLine("Про який тур Ви хочете дізнатися більше?");
                        for (int i = 0; i<Choices.Length; i++)
                            Console.WriteLine((i + 1) + ". Тур у " + Choices[i].cityName + ", " + Choices[i].counName + " від " + Choices[i].MonthSt + " місяця і до " + Choices[i].MonthEnd + " місяця від агентства " + Choices[i].AgencyName);
                        Console.Write("Введіть номер туру: ");
                        //int check4 = 0;
                        int TourOfChoice = Convert.ToInt32(Console.ReadLine());
                        if (TourOfChoice-1 >= Choices.Length || TourOfChoice - 1 < 0)
                            Console.WriteLine("Неправильно введено номер туру.");
                        else
                            Choices[TourOfChoice - 1].ShowInfoTour();
                        break;
                    case 5:
                        Console.WriteLine("Про які тур агентства Ви хочете дізнатися більше?");
                        for (int i = 0; i < agencies.Length; i++)
                            Console.WriteLine((i + 1) + ". Тур агентство " + agencies[i].AgencyName + ".");
                        Console.Write("Введіть номер тур агентства: ");
                        int AgencyOfChoice = Convert.ToInt32(Console.ReadLine());
                        if (AgencyOfChoice - 1 >= agencies.Length || AgencyOfChoice - 1 < 0)
                            Console.WriteLine("Неправильно введено номер агентства.");
                        else
                            agencies[AgencyOfChoice - 1].ShowInfoAgency();
                        break;
                    case 0:
                        Console.WriteLine("Дякуємо за користування нашими послугами!");
                        Console.ReadKey();
                        break;
                }        
            }
        }
    }
}