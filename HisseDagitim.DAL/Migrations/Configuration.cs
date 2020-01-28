namespace HisseDagitim.DAL.Migrations
{
    using HisseDagitim.Model.Somut;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HisseDagitim.DAL.Contexts.EfContext.HisseDagitimEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
		
        protected override void Seed(HisseDagitim.DAL.Contexts.EfContext.HisseDagitimEntities context)
        {/*
			var hsahips = new List<HisseSahibi>//excel magic
			{
				new HisseSahibi { HSahipAdi = "Shuaib Charles", isTuzel =false, Adres = "920 Noemi Lane, Clementville, West Coast, 3349", Email = "ShuaibCharles@gmail.com", TCKN_VergiNo = "4072589", Telefon = "+9053555582582"},
				new HisseSahibi { HSahipAdi = "Sumayyah Holloway", isTuzel =false, Adres = "7 West Place, Reeseville, Auckland, 3429", Email = "SumayyahHolloway@yahoo.com", TCKN_VergiNo = "5524327", Telefon = "+9054555474352"},
				new HisseSahibi { HSahipAdi = "Kyal Aguirre", isTuzel =false, Adres = "30 Collier Place, Howellville, Southland, 2230", Email = "KyalAguirre@yandex.com", TCKN_VergiNo = "6168684", Telefon = "+9050555157226"},
				new HisseSahibi { HSahipAdi = "Humayra Petty", isTuzel =false, Adres = "069 Frankie Street, Samston, Waikato, 1169", Email = "HumayraPetty@rng.com", TCKN_VergiNo = "4346673", Telefon = "+9050555931758"},
				new HisseSahibi { HSahipAdi = "Kirstin Mcintyre", isTuzel =false, Adres = "94 Bechtelar Drive, Denaston, Nelson, 8755", Email = "KirstinMcintyre@gmail.com", TCKN_VergiNo = "2712200", Telefon = "+9050555368609"},
				new HisseSahibi { HSahipAdi = "Jess Brookes", isTuzel =false, Adres = "2 Sarah Rise, Janessaston, Auckland, 4389", Email = "JessBrookes@yahoo.com", TCKN_VergiNo = "7513537", Telefon = "+9054555075430"},
				new HisseSahibi { HSahipAdi = "Kya Hutton", isTuzel =false, Adres = "0 Zemlak Heights, Vivienneville, West Coast, 3947", Email = "KyaHutton@yandex.com", TCKN_VergiNo = "4072590", Telefon = "+9053555422468"},
				new HisseSahibi { HSahipAdi = "Macy Cuevas", isTuzel =false, Adres = "37 Shields Close, Kirstinston, Taranaki, 8108", Email = "MacyCuevas@rng.com", TCKN_VergiNo = "4072590", Telefon = "+9050555767923"},
				new HisseSahibi { HSahipAdi = "Zaki Santana", isTuzel =false, Adres = "6 Schneider Hill, Kathlynston, Manawatu-Whanganui, 1550", Email = "ZakiSantana@gmail.com", TCKN_VergiNo = "5524328", Telefon = "+9050555041293"},
				new HisseSahibi { HSahipAdi = "Atticus Shea", isTuzel =false, Adres = "0 Dale Street, Tylerston, West Coast, 3020", Email = "AtticusShea@yahoo.com", TCKN_VergiNo = "6168685", Telefon = "+9050555982185"},
				new HisseSahibi { HSahipAdi = "Compass Metal Co.", isTuzel =true, Adres = "804 O'Reilly Place, Cristobalston, Manawatu-Whanganui, 0778", Email = "CompassMetalCo@cmcinternational.com", TCKN_VergiNo = "4346674", Telefon = "+9050555724488"},
				new HisseSahibi { HSahipAdi = "Canada Revival Co.", isTuzel =true, Adres = "76 Smitham Esplanade, Marcellusville, Gisborne, 3094", Email = "executivecr@crcbranch.com", TCKN_VergiNo = "2712201", Telefon = "+9050555743825"},
				new HisseSahibi { HSahipAdi = "Jorden Sumner", isTuzel =false, Adres = "528 Jameson Avenue, Roderickville, Hawkes Bay, 8639", Email = "JordenSumner@gmail.com", TCKN_VergiNo = "7513538", Telefon = "+9050555560280"},
				new HisseSahibi { HSahipAdi = "Sianna Butler", isTuzel =false, Adres = "7 Schiller Line, Felipeston, Auckland, 2813", Email = "SiannaButler@yahoo.com", TCKN_VergiNo = "4072591", Telefon = "+9054555231348"},
				new HisseSahibi { HSahipAdi = "Shuaib Charles", isTuzel =false, Adres = "6 Ettie Place, Laurieville, Nelson, 4310", Email = "ShuaibCharles@yandex.com", TCKN_VergiNo = "4072591", Telefon = "+9050555908046"},
				new HisseSahibi { HSahipAdi = "Eliza Russell", isTuzel =false, Adres = "0 Jewell Road, Dedrickville, Gisborne, 0143", Email = "ElizaRussell@rng.com", TCKN_VergiNo = "5524329", Telefon = "+9054555678153"},
				new HisseSahibi { HSahipAdi = "Christina Townsend", isTuzel =false, Adres = "13 Alfred Crescent, Martineston, Otago, 2665", Email = "ChristinaTownsend@gmail.com", TCKN_VergiNo = "6168686", Telefon = "+9050555192493"},
				new HisseSahibi { HSahipAdi = "Samah Mathews", isTuzel =false, Adres = "410 Linnie Heights, Nicolasston, Northland, 1065", Email = "SamahMathews@yahoo.com", TCKN_VergiNo = "4346675", Telefon = "+9050555603231"},
				new HisseSahibi { HSahipAdi = "Jaidon Cortez", isTuzel =false, Adres = "54 Mylene Parade, Magnoliaville, Otago, 3950", Email = "JaidonCortez@yandex.com", TCKN_VergiNo = "2712202", Telefon = "+9050555588191"},
				new HisseSahibi { HSahipAdi = "Murat Armstrong", isTuzel =false, Adres = "441 Camila Crescent, Teresaston, Gisborne, 4468", Email = "MuratArmstrong@rng.com", TCKN_VergiNo = "7513539", Telefon = "+9054555775454"},
				new HisseSahibi { HSahipAdi = "Ceri Martin", isTuzel =false, Adres = "44 Zemlak Line, Bettyeville, Bay of Plenty, 2707", Email = "CeriMartin@gmail.com", TCKN_VergiNo = "4072592", Telefon = "+9050555505853"},
				new HisseSahibi { HSahipAdi = "Wiktor Holland", isTuzel =false, Adres = "702 Nicole Quay, Jennieston, Canterbury, 7385", Email = "WiktorHolland@yahoo.com", TCKN_VergiNo = "4072592", Telefon = "+9050555495812"},
				new HisseSahibi { HSahipAdi = "Violet Co.", isTuzel =true, Adres = "5 Nikolas Terrace, Maggieville, Northland, 1973", Email = "liz.violet@vcpremium.com", TCKN_VergiNo = "5524330", Telefon = "+9050555298519"},
				new HisseSahibi { HSahipAdi = "Jade Bowman", isTuzel =false, Adres = "79 Deonte Line, Annabellston, Canterbury, 4891", Email = "JadeBowman@rng.com", TCKN_VergiNo = "6168687", Telefon = "+9050555444665"},
				new HisseSahibi { HSahipAdi = "Maryam Bernard", isTuzel =false, Adres = "89 Satterfield Close, Dellaston, Waikato, 4670", Email = "MaryamBernard@gmail.com", TCKN_VergiNo = "4346676", Telefon = "+9053555073629"},
				new HisseSahibi { HSahipAdi = "Hettie Werner", isTuzel =false, Adres = "062 Shannon Way, Murlston, Manawatu-Whanganui, 1270", Email = "HettieWerner@yahoo.com", TCKN_VergiNo = "2712203", Telefon = "+9054555818105"},
				new HisseSahibi { HSahipAdi = "My Apple Co.", isTuzel =true, Adres = "4 Cummings Highway, Treverston, Northland, 4480", Email = "executive@mac.com", TCKN_VergiNo = "7513540", Telefon = "+9050555615018"},
				new HisseSahibi { HSahipAdi = "Sarah-Louise Bowman", isTuzel =false, Adres = "922 Marquise Parade, Dandreston, Hawkes Bay, 9984", Email = "SLouiseBowman@rng.com", TCKN_VergiNo = "4072593", Telefon = "+9054555757203"}
			};

			foreach (var item in hsahips)
			{
				context.HisseSahipleri.Add(item);
			}
			context.SaveChanges();

			var hissesenets = new List<HisseSenedi>
			{
				new HisseSenedi{ HisseDegeri =  3.13m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   1   ), HisseNo =    1   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3m      , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   2   ), HisseNo =    2   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.11m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   3   ), HisseNo =    3   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.93m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   4   ), HisseNo =    4   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.83m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   5   ), HisseNo =    5   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.73m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   6   ), HisseNo =    6   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.81m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   7   ), HisseNo =    7   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.94m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   8   ), HisseNo =    8   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.85m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   9   ), HisseNo =    9   , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3m      , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   10  ), HisseNo =    10  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.06m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   11  ), HisseNo =    11  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.86m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   12  ), HisseNo =    12  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.74m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   13  ), HisseNo =    13  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.91m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   14  ), HisseNo =    14  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.02m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   15  ), HisseNo =    15  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.97m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   16  ), HisseNo =    16  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.12m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   17  ), HisseNo =    17  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.9m    , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   18  ), HisseNo =    18  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.99m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   19  ), HisseNo =    19  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.79m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   20  ), HisseNo =    20  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.08m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   21  ), HisseNo =    21  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.03m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   22  ), HisseNo =    22  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.01m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   23  ), HisseNo =    23  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.88m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   24  ), HisseNo =    24  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.91m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   25  ), HisseNo =    25  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3m      , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   26  ), HisseNo =    26  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.83m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   27  ), HisseNo =    27  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.85m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   28  ), HisseNo =    28  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  3.01m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   1   ), HisseNo =    29  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.72m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   2   ), HisseNo =    30  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.91m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   3   ), HisseNo =    31  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.75m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   4   ), HisseNo =    32  , HisseTertipNo =   1   },
				new HisseSenedi{ HisseDegeri =  2.96m   , HisseYili = 2012, isGecerli =         true    , HisseSahibi = hsahips.Single(p=>p.ID ==   5   ), HisseNo =    33  , HisseTertipNo =   1   }
			};//.ForEach(a => context.HisseSenetleri.Add(a));

			foreach (var senet in hissesenets)
			{
				context.HisseSenetleri.Add(senet);
			}

			context.SaveChanges();

			List<decimal> sums = new List<decimal>();

			foreach (var sahibis in context.HisseSahipleri)
			{
				decimal sumHisse = 0m;
				foreach (var hisses in sahibis.Hisseler)
				{
					sumHisse += hisses.HisseDegeri; 
				}
				sahibis.ToplamHisseDegeri = sumHisse;
				  
			}

			context.SaveChanges();


			foreach (var item in context.HisseSenetleri)
			{
				for (int i = 0; i < 10; i++)
				{
					context.KarPayiPullari.Add(new KarPayiPulu { HisseSenedi = item, Carpan = 0m, isDagitildi = false, Yil = (item.HisseYili + i) });
				}
				for (int j = 1; j < 16; j++)
				{
					context.YeniPayPullari.Add(new YeniPayPulu { HisseSenedi = item, Carpan = 0m, isDagitildi = false, PulNo = j });
				}
			}

			context.SaveChanges();

			context.Kullanicilar.Add(new Kullanici { KullaniciAdi = "sa", Password = "123", });
			context.Kullanicilar.Add(new Kullanici { KullaniciAdi = "sa2", Password = "246", });

			context.SaveChanges();

			context.Log.Add(new Log { Kullanici = context.Kullanicilar.Single(p => p.KullaniciAdi == "sa"), Aciklama = "ornek" });
			context.Log.Add(new Log { Kullanici = context.Kullanicilar.Single(p => p.KullaniciAdi == "sa2"), Aciklama = "ornek2" });

			context.SaveChanges();*/
		}
		
    }
}
