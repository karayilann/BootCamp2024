using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    public static class GameData
    {
        public static Dictionary<string, GameState> States = new Dictionary<string, GameState>
        {
            {
                "start", new GameState
                {
                    StateText = "Gece parkta yürüyüşe çıkmıştın. Tek istediğin biraz huzurdu. Lanet olsun. Yerde yüzüstü yatan bir kadın gördün. Biraz uzakta koşan biri var. Ne yapacaksın?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Yardım et.", NextState = "yardimEt" },
                        new GameStateOption { OptionText = "Görmezden gel ve yürümeye devam et. Tanık manık yazarlar neme lazım.", NextState = "gecDevam" }
                    },
                    BackgroundImage = GameManager.Instance.firstImage
                }
            },
            {
                "gecDevam", new GameState
                {
                    StateText = "Vicdan azabından geceleri uyuyamıyorsun. Belki de kadın öldü. Allah cezanı verecek. Başa dön.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "yardimEt", new GameState
                {
                    StateText = "Kadına doğru eğildin. Kadını sırtüstü çevirdiğinde yaralandığını fark ettin. Bu sırada polisler geldi ve seni elleri kanlı görünce yakalamak istiyorlar.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Yakalamaya diren. Bakacaaaz, kimin amcası daha büyük, bakacaaaz.", NextState = "tutuklamayaDiren" },
                        new GameStateOption { OptionText = "Polislerle git, efendi ol.", NextState = "polislerleGit" }
                    },
                    BackgroundImage = GameManager.Instance.secondImage

                }
            },
            {
                "tutuklamayaDiren", new GameState
                {
                    StateText = "Yakalamaya direnip polisten kaçmaya çalışırken bir polisin yaralanmasına sebep oldun. Onların amcası daha büyükmüş. Direkt hapse gönderildin.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "polislerleGit", new GameState
                {
                    StateText = "Sorgu odasındasın. Polisler avukat isteyip istemediğini soruyor.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Avukat istemiyorum. Bende mangal gibi yürek var. Benim amcam Vuran GAYA. Bakacaaaz.", NextState = "avukatiReddet" },
                        new GameStateOption { OptionText = "Avukat iste. Akıllı ol.", NextState = "avukatIste" }
                    }
                }
            },
            {
                "avukatiReddet", new GameState
                {
                    StateText = "Polis sorguya başladı. Öldürülen kadının ünlü bir sosyal medya fenomeni olduğunu öğrendin. Kadını tanıyıp tanımadığını sordular. Ne cevap vereceksin?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Evet, tanıyorum. Ne var bunda, gebeş kaplumbağa?", NextState = "evetTaniyorum" },
                        new GameStateOption { OptionText = "Hayır, tanımıyorum. İki gözüm önüme aksın.", NextState = "hayirTanimiyorum" }
                    }
                }
            },
            {
                "evetTaniyorum", new GameState
                {
                    StateText = "Sadece tanımakla kalmayıp kadının her paylaşımını da takip ettiğin ortaya çıktı. Polis seni stalker olmakla suçluyor. Derdini mahkemede de anlatamadın. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "hayirTanimiyorum", new GameState
                {
                    StateText = "Polis sosyal medya hesaplarından öldürülen kadını takip ettiğini buldu. Hatta tüm fotoğraflarını beğenip birçoğuna yorum yaptığını keşfetti. Yalan söylediğin için mahkemede de derdini anlatamadın. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "avukatIste", new GameState
                {
                    StateText = "Devlet sana CMK'dan avukat mı atasın, yoksa kendine bir avukat mı bulacaksın?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "CMK'dan ücretsiz avukat atansın. Zaten masumum. Amcam da Vuran GAYA. Bakacaaaz.", NextState = "cmkAvukat" },
                        new GameStateOption { OptionText = "Paraya kıyıp ünlü bir avukat tutacağım.", NextState = "unluAvukat" }
                    }
                }
            },
            {
                "cmkAvukat", new GameState
                {
                    StateText = "Devlet sana CMK'dan ücretsiz bir avukat atadı. Avukat yeni mezun. İlk dosyasını almaktan onur duyduğunu, amcanız Vuran GAYA'nın büyük bir hayranı olduğunu söyledi.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Paraya kıyıp ünlü bir avukat tutacağım. Kelde tıraş öğrenir şimdi bu. Başım yanmasın.", NextState = "unluAvukat" },
                        new GameStateOption { OptionText = "Bu avukat ile devam et. Çocuğu gözün tuttu. Amcanı sevdiğine göre adamın hasından anlıyor.", NextState = "cmkDevam" }
                    }
                }
            },
            {
                "cmkDevam", new GameState
                {
                    StateText = "Avukat sana akıl verdi. Takdir-i ilahi abicim, burada ne yazıyorsa o, polislerle inatlaşma dedi. Polisin yazdığı ifadeyi tatlı bakışlarınla imzaladın. Mahkeme, avukat eşliğinde alınan ifadeni doğru kabul etti. Ne desen boş. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "unluAvukat", new GameState
                {
                    StateText = "Alanında çok ünlü bir avukat buldun. Kesenin ağzını açtın, bir ev parası verdin. İfadeden önce seni özel bir odaya soktu. Olayı senden dinlemek istiyor. Ne anlatacaksın?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Avukata suçlu olduğunu söyle. Şakadan zarar gelmez.", NextState = "benOldurdum" },
                        new GameStateOption { OptionText = "Gördüklerini anlat. Sen suçlu değilsin.", NextState = "gordukleriniAnlat" }
                    }
                }
            },
            {
                "benOldurdum", new GameState
                {
                    StateText = "Avukatın aynı zamanda koyu bir feminist çıktı. Şaka yaptım desen de inandıramadın. Avukatsız kaldığın için devlet sana CMK'dan ücretsiz avukat atadı.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "CMK avukatıyla görüş.", NextState = "cmkDevam" }
                    }
                }
            },
            {
                "gordukleriniAnlat", new GameState
                {
                    StateText = "Olayı anlatmaya başladın. Kaçan kişiden bahsedince avukat detayları hatırlayıp hatırlamadığını sordu. Aklına bir görüntü düştü. Sarı saçlar... Avukat bu bilgiyi polise aktardı. Polis sarı saçları ve sicil kaydı olan bölgedeki 3 kişinin fotoğrafını sana göstererek teşhis etmeni istedi.",
                    BackgroundImage = GameManager.Instance.secondImage,
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Kısa sarı saçları olan kadının fotoğrafını seç.", NextState = "kisaSariKadin" },
                        new GameStateOption { OptionText = "Uzun sarı saçları olan erkeğin fotoğrafını seç.", NextState = "uzunSariErkek" },
                        new GameStateOption { OptionText = "Uzun sarı saçları olan kadının fotoğrafını seç.", NextState = "uzunSariKadin" }
                    }
                }
            },
            {
                "kisaSariKadin", new GameState
                {
                    StateText = "Kadının olay anında başka yerde olduğunu kanıtlayacak tanıkları varmış. Tanıklar mahkemede dinlendi. Suçtan kurtulmaya yönelik beyanlarda bulunduğunu düşünen mahkeme heyeti ağırlaştırılmış müebbet verdi. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Teşhis işlemine geri dön.", NextState = "gordukleriniAnlat" }
                    }
                }
            },
            {
                "uzunSariErkek", new GameState
                {
                    StateText = "Adamın öldürülen fenomenin eski sevgilisi olduğu ortaya çıktı. Ancak polis detaylara inince, adamın o tarihte karısıyla İtalya'da balayında olduğu ortaya çıktı. Mahkeme sana yalancı gözüyle bakıyor. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Teşhis işlemine geri dön.", NextState = "gordukleriniAnlat" }
                    }
                }
            },
            {
                "uzunSariKadin", new GameState
                {
                    StateText = "Kadınla öldürülen fenomen arasında hiçbir bağ yok. Allah'tan ümit kesilmez. Olay yerine giderek polislere yardımcı olmak ister misin?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Korkanın çocuğu olmaz. Pilavdan dönenin kaşığı kırılsın.", NextState = "olayYerineGit" },
                        new GameStateOption { OptionText = "Ölsem bile oraya tekrar dönmem. Başıma yine iş gelir.", NextState = "olayYerineGitme" }
                    }
                }
            },
            {
                "olayYerineGitme", new GameState
                {
                    StateText = "Daha fazla kanıt bulamadığın ve bütün kanıtlar seni gösterdiği için suç üstüne kaldı. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Teşhis işlemine geri dön.", NextState = "gordukleriniAnlat" }
                    }
                }
            },
            {
                "olayYerineGit", new GameState
                {
                    StateText = "Parkta polis ve avukatla berabersin. Bir an için polisler senden gözünü ayırdı. Ne yapacaksın?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Kaçmaya çalış. Vınn bas gaza işte sana tas kafa...", NextState = "kacmayaCalis" },
                        new GameStateOption { OptionText = "Olay yerini incele.", NextState = "incele" }

                    }
                }
            },
            {
                "kacmayaCalis", new GameState
                {
                    StateText = "Koşmaya başladın. Ellerin kelepçeli. Yolda alet çantalı birine rastladın.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Adamı durdur ve yardım iste.", NextState = "yardimIste" },
                        new GameStateOption { OptionText = "Koşmaya devam et.", NextState = "kosmayaDevam" }

                    }
                }
            },
            {
                "yardimIste", new GameState
                {
                    StateText = "Adam kelepçelerini görünce bağırmaya başladı. Polisler seni yakaladı. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "kosmayaDevam", new GameState
                {
                    StateText = "Dakikalarca koştun. Polislerden uzaklaştığını düşündüğün anda biraz durup dinlenmek istedin. Polisler sana yetişti. HAPSİ BOYLADIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön.", NextState = "start" }
                    }
                }
            },
            {
                "incele", new GameState
                {
                    StateText = "Avukatın ve polisle birlikte parkta dolaştın. Koşarak uzaklaşan kişi sanki buradaydı... Buldun! Bıçak orada duruyor!",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Allah'ım sen büyüksün.", NextState = "bicak" }
                    }
                }
            },
            {
                "bicak", new GameState
                {
                    StateText = "Tekrar karakoldasın. Nezaretteyken avukatın geldi. Bıçağın üstündeki parmak izinin fotoğrafını teşhis ettiğin kadına ait olduğunu söyledi.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "YA-ŞA-SIN. KUR-TUL-DUM. BENİM AMCAN VURAN GAYA. SADRAZAMKÖPRÜ İLÇE BAŞGANI.", NextState = "masum" }
                    }
                }
            },
            {
                "masum", new GameState
                {
                    StateText = "Gerçek suçlu bulundu. Artık özgürsün. Peki olayın aslını merak ediyor musun? Cinayetin sebebini öğrenmek istemez misin?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Cinayetin nedenine merak ediyorum.", NextState = "final" },
                        new GameStateOption { OptionText = "Aman, neme lazım. Kedinin başına ya meraktan... Ben gidiyorum arkadaş.", NextState = "final" }
                    }
                }
            },
            {
                "final", new GameState
                {
                    StateText = "Yaşadıklarınız için çok üzgünüz. Neyse ki gerçek katil yakalandı. Katil Melis adında genç bir kadınmış. Öldürülen fenomeni takıntı haline getirmiş. Bir süredir onu takip ediyormuş. Sosyal medya hesaplarından gönderilmiş binlerce mesaj bulduk. Onu takip edip parkta sıkıştırmış. Suçunu itiraf etti. Artık özgür birisiniz!",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Yarın iş var. Gideyim de yatayım.", NextState = "tebrikler" },
                    }
                }
            },
            {
                "tebrikler", new GameState
                {
                    StateText = "Masum birisin!",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa dön. Dertsiz başına dert al.", NextState = "start" },
                    }
                }
            }
        };
    }

    public class GameState
    {
        public string StateText { get; set; }
        public GameStateOption[] Options { get; set; }
        public Sprite BackgroundImage { get; set; }
    }


    public class GameStateOption
    {
        public string OptionText { get; set; }
        public string NextState { get; set; }
    }
}