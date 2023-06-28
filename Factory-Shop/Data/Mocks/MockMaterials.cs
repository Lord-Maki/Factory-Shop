﻿using Factory_Shop.Data.Interfaces;
using Factory_Shop.Data.Models;


namespace Factory_Shop.Data.Mocks
{
    public class MockMaterials : IMaterials
    {
        private readonly IMatCategory CategoryMat = new MockCategory();
        public IEnumerable<Materials> AllMaterials
        {
           get
            {
                return new List<Materials>
                {
                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "А-10",
                    ShortDesc = "АСФАОТОБЕТОННА СУМІШ ДРІБНОЗЕРНИСТА, ЩІЛЬНА, ТИП А, МАРКА I (СКОРОЧЕНО A-10)",
                    LongDesc = "АБС А-10 - щебенева суміш, з дрібнозернистим наповнювачем (до 20 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну) погоду. Гаряча АБС А-10 укладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "А-20",
                    ShortDesc = "А-20 АБС ДРІБНОЗЕРНИСТА, ЩІЛЬНА, ТИП А, МАРКА I (СКОРОЧЕНО А-20)",
                    LongDesc = "АБС А-20 - щебенева суміш, з дрібнозернистим наповнювачем (до 20 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну) погоду. Гаряча АБС А-20 укладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. - Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "А-40",
                    ShortDesc = "А-40 АБС КРУПНОЗЕРНИСТА, ЩІЛЬНА, ТИП А, МАРКА I (СКОРОЧЕНО - А-40)",
                    LongDesc = "АБС А-40 - щебенева суміш, з крупнозернистим наповнювачем (із розміром зерна до 40 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну) погоду. Гаряча АБС А-40 укладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. - Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "Б-10",
                    ShortDesc = "Б-10 АБС ДРІБНОЗЕРНИСТА, ЩІЛЬНА, ТИП Б, МАРКА I (СКОРОЧЕНО - Б-10)",
                    LongDesc = "АБС Б-10 - щебенева суміш, з дрібнозернистим наповнювачем (до 20 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну) погоду. Гаряча АБС Б-10 вкладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "Б-20",
                    ShortDesc = "Б-20 АБС ДРІБНОЗЕРНИСТА, ЩІЛЬНА, ТИП Б. МАРКА I (СКОРОЧЕНО- Б-20)",
                    LongDesc = "АБС Б-20 - щебенева суміш, з дрібнозернистим наповнювачем (до 20 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну погоду. Гаряча АБС Б-20 вкладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Асвальтобетон",
                    Group = "Б-40",
                    ShortDesc = "Б-40 АБС КРУПНОЗЕРНИСТА, ЩІЛЬНА, ТИП Б, МАРКА I (СКОРОЧЕНО- Б-40)",
                    LongDesc = "АБС Б-40 - щебенева суміш, з крупнозернистим наповнювачем (із розміром до 40 мм), щільна (залишкова пористість асфальтобетону від 2 до 7% включно). Укладають в суху (бажано безвітряну) погоду. Гаряча АБС Б-40 укладається при температурі не нижче 5°С (навесні), і не нижче 10°С (восени). Тепла не нижче -10°С. - Товщина шару, що укладається повинна бути не менше 4 см. Ущільнення асфальтобетонної суміші виконується відразу після її укладання.",
                    Img = "/img/Materials/Asphalt_concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Бетон",
                    Group = "КЛАСИЧНИЙ",
                    ShortDesc = "Класичний бетон складається з щебеню, піску, цементу, води і спеціальних добавок. Щебінь і пісок утворюють скелет-основу: а цемент, вода і добавки утворюють цементний клей, який з'єднує кожну частинку заповнювача між собою в міцний штучний камінь- бетон.",
                    LongDesc = "Класичний бетон складається з щебеню, піску, цементу, води і спеціальних добавок. Щебінь і пісок утворюють скелет-основу: а цемент, вода і добавки утворюють цементний клей, який з'єднує кожну частинку заповнювача між собою в міцний штучний камінь- бетон.",
                    Img = "/img/Materials/Concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Бетон",
                    Group = "ЗИМОВІ",
                    ShortDesc = "Зимовий бетон отримують введенням до складу суміші, так званих, ПМД. - протиморозних добавок. Процентний показник добавки, яка вводиться, розраховується виходячи з марки цементу, яка застосовється в бетоні: кількості суміші, передбачуваних температурних умов при її використанні.",
                    LongDesc = "Зимовий бетон отримують введенням до складу суміші, так званих, ПМД. - протиморозних добавок. Процентний показник добавки, яка вводиться, розраховується виходячи з марки цементу, яка застосовється в бетоні: кількості суміші, передбачуваних температурних умов при її використанні.",
                    Img = "/img/Materials/Concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Бетон",
                    Group = "ЛІТНІ",
                    ShortDesc = "Літній бетон- класичний бетон без протиморозних добавок.",
                    LongDesc = "Літній бетон- класичний бетон без протиморозних добавок.",
                    Img = "/img/Materials/Concrete.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.Last()
                    },

                    new Materials
                    { 
                    Name = "Щебінь гранітний",
                    Group = "ФРАКЦІЯ 5-10 ММ",
                    ShortDesc = "Дрібна фракційна група гранітного щебеню має діаметр 5-10 мм.",
                    LongDesc = "Дрібна фракційна група гранітного щебеню має діаметр 5-10 мм. Вона ефективна при виконанні будівельних робіт через дрібний розмір і завдяки високим технічним характеристикам. Щебінь фракції 5-10 отримують при дробленні каменю та відсіювання зерна щебеню потрібного діаметру. Щебінь цієї фракції високу насипну щільність, в суміші дає максимальне эчеплення Крім цього, має властивості: • хороший показник міцності (1200-1400 кг/см2) стійкість до морозу • низький показник радіоактивності . відсоток лещадністю невисокий - до 15%.",
                    Img = "/img/Materials/Crushed_stone.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Щебінь гранітний",
                    Group = "ФРАКЦІЯ 5-20 мм",
                    ShortDesc = "Щебінь фракції 5-20 має діаметр зерен від 5 до 20 мм.",
                    LongDesc = "Щебінь фракції 5-20 має діаметр зерен від 5 до 20 мм. Являє собою суміш фракцій 5-10 мм і 10-20 мм. Відноситься до дрібної фракції. Видобувається з гірських порід: гравію, вапна, граніту. При цьому до зовнішніх факторів найбільш стійкий гранітний щебінь. Щебінь фракції 5-20 мм має наступні технічні характеристики: •низька радіоактивність • морозостійкість (здатний витримати більше 400 повних циклів заморожування і відтавання) • низький показник водопоглинання.",
                    Img = "/img/Materials/Crushed_stone.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Щебінь гранітний",
                    Group = "ФРАКЦІЯ 10-20 ММ",
                    ShortDesc = "Щебінь фракції 10-20 має діаметр зерен від 10 до 20 мм.",
                    LongDesc = "Щебінь фракції 10-20 має діаметр зерен від 10 до 20 мм. Виробляють з гірських порід: такий щебінь є досить міцним будівельним матеріалом. Відноситься до фракції середнього будівельних робіт, що обумовлено хорошими технічними розміру. Щебінь фракції 10-20 затребуваний при різних видах характеристиками: низька лещадность (до 15%) міцність морозостійкість висока щільність низький показник радіоактивності.",
                    Img = "/img/Materials/Crushed_stone.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Щебінь гранітний",
                    Group = "ФРАКЦІЯ 20-40 ММ",
                    ShortDesc = "Щебінь фракції 20-40 має діаметр зерен від 20 до 40 мм.",
                    LongDesc = "Щебінь фракції 20-40 має діаметр зерен від 20 до 40 мм. Найбільш популярний вид щебеню. Розмір зерен у цієї марки являє собою «золоту середину» у порівнянні з більш великими і більш дрібними різновидами. Така особливість дозволяє використовувати матеріал для вирішення широкого спектра будівельних завдань. Відноситься до фракції середнього розміру. Щебінь фракції 20-40 застосовується для: виготовлення бетону для великих конструкцій створення фундаменту будівлі Дренажних робіт будівництва залізничних доріг облаштування автомайданчиків.",
                    Img = "/img/Materials/Crushed_stone.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Щебінь гранітний",
                    Group = "ФРАКЦІЯ 40-70 ММ",
                    ShortDesc = "До фракції 40-70 відносять щебінь, діаметр зерен якого становить 40-70 мм.",
                    LongDesc = "До фракції 40-70 відносять щебінь, діаметр зерен якого становить 40-70 мм. Середня щільність такого щебеню від 1,45 до 1,55 г/ м3. Отримують його способом дроблення гірських порід. При виробництві від загальної маси виходить до 60% продукту. Оскільки щебінь фракції 40-70 мм є досить великим, його нерідко переробляють на більш дрібні фракції.",
                    Img = "/img/Materials/Crushed_stone.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Пісок гранітний",
                    Group = "Штучний",
                    ShortDesc = "Пісок будівельний (відсів), фракція 0-5 мм отримують дроблінням твердого натурального каменю.",
                    LongDesc = "Пісок будівельний (відсів), фракція 0-5 мм отримують дроблінням твердого натурального каменю. Його насипна щільність 1330 кг/куб. м. Зовні він нагадує пісок, але на відміну від нього майже не містить глинистих домішок, органіки і пилу (їх частка нормується на рівні 0,4% від загальної ваги). Відсоток голчастих зерен не перевищує 15%, тому маса легко укладається і трамбується. Відсів міцний: допустима межа тиску становить 120 МПа (марка М1200). Матеріал стійкий до низьких температур. екологічно безпечний.",
                    Img = "/img/Materials/Granite_sand.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    },

                    new Materials
                    { 
                    Name = "Пісок річковий",
                    Group = "Природній",
                    ShortDesc = "Річковий пісок це природний матеріал, який добувають з дна річок.",
                    LongDesc = "Річковий пісок це природний матеріал, який добувають з дна річок. Він практично не містить глинистих частинок, а так же каменів і камінчиків. Частинки річкового піску бувають дрібними (до 2 мм). Середніми (2.0 до 2.8 мм) і великими (від 2.9 до 5 мм). Річковий пісок вважається універсальним матеріалом і Використовується для будь-яких видів будівельних робіт, так як в його складі відсутні різні домішки.",
                    Img = "/img/Materials/River_sand.PNG",
                    Price = 0,
                    Available = true,
                    Category = CategoryMat.AllCategory.First()
                    }
                };
            }
        }


        public Materials GetMaterials(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
