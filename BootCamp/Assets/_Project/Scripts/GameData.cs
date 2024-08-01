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
                    StateText = "GECE PARKTA YÜRÜYÜŞE ÇIKMIŞTIN. AZ İLERİDE YERDE YATAN BİRİ VARDI. BİRAZ UZAĞINDA İSE KOŞAN BİRİNİ GÖRDÜN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Görmezden Gel ve Yürümeye Devam Et", NextState = "gecDevam" },
                        new GameStateOption { OptionText = "Yardım Et", NextState = "yardimEt" }
                    },
                    BackgroundImage = GameManager.Instance.firstImage
                }
            },
            {
                "yardimEt", new GameState
                {
                    StateText = "Koşarak kadının yanına gittin. Kadını yüz üstü çevirdiğinde bıçağı fark ettin. Bu sırada polisler geldi ve seni elleri kanlı görünce tutukladılar.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Polislerle Git", NextState = "polislerleGit" },
                        new GameStateOption { OptionText = "Tutuklamaya Diren", NextState = "tutuklamayaDiren" }
                    },
                    BackgroundImage = GameManager.Instance.secondImage
                }
            },
            {
                "gecDevam", new GameState
                {
                    StateText = "Oyun başarısız. Başa dön.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "polislerleGit", new GameState
                {
                    StateText = "Sorgu odasındasın. Polisler avukat isteyip istemediğini soruyor.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Avukat İste", NextState = "avukatIste" },
                        new GameStateOption { OptionText = "Avukatı Reddet", NextState = "avukatiReddet" }
                    }
                }
            },
            {
                "tutuklamayaDiren", new GameState
                {
                    StateText = "Tutuklamaya direnip polisten kaçmaya çalışırken bir polisin yaralanmasına sebep oldun. Direkt hapse gönderildin. Oyun başa döner.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "avukatIste", new GameState
                {
                    StateText = "CMK’dan avukat atandı. Avukat alanında çok iyi ve davanı ücretsiz kabul etti. Seninle baş başa konuşmak istiyor.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Avukatla Devam Et", NextState = "avukatDevam" },
                        new GameStateOption { OptionText = "Avukatı Reddet", NextState = "avukatiReddet" }
                    }
                }
            },
            {
                "avukatiReddet", new GameState
                {
                    StateText = "Polis sosyal medya hesaplarından öldürülen kadını takip ettiğini buldu. Tüm fotoğraflarını beğenip yorum yaptığını keşfetti. Yalan söyledin, suçüstü yakalandın. TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "avukatDevam", new GameState
                {
                    StateText = "Avukatın olayları senden dinlemek istedi. Kaçan kişiye dair bir detay gördün mü?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Evet", NextState = "evetDetay" },
                        new GameStateOption { OptionText = "Hayır", NextState = "hayirDetay" }
                    }
                }
            },
            {
                "evetDetay", new GameState
                {
                    StateText = "İlk sahne yeniden görünür. Kaçan kişi hafifçe kafasını çevirmiştir ve bir tutam sarı saç görünür. Avukatınla bu bilgiyi paylaştın.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Devam Et", NextState = "devamAvukat" }
                    }
                }
            },
            {
                "hayirDetay", new GameState
                {
                    StateText = "Başka bir detay hatırlayamadın. TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "devamAvukat", new GameState
                {
                    StateText = "Avukat, bu bilgiyi polise aktardı. Polis, tarifine uyan ve suç kaydı bulunan 3 kişiyi buldu. Bu kişilerin fotoğraflarına bakmanı istedi.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Evet", NextState = "evetFoto" },
                        new GameStateOption { OptionText = "Hayır", NextState = "hayirFoto" }
                    }
                }
            },
            {
                "evetFoto", new GameState
                {
                    StateText = "Evet! Bu olmalı! Ufak tefek biri zannetmiştim fakat kadınmış! Avukat: Hala seni kurtarma şansımız çok düşük. Cinayet silahı kayıp ve üstü başı kanlı bulunan sensin.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Devam Et", NextState = "devamFoto" }
                    }
                }
            },
            {
                "hayirFoto", new GameState
                {
                    StateText = "Kadının olay saati için tanığı varmış... Polis, onları yanlış yönlendirmeye çalıştığını düşündü. TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "devamFoto", new GameState
                {
                    StateText = "Belki olay yerine dönsen daha fazla detay hatırlayabilirsin. Ne dersin?",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Evet", NextState = "olayYeri" },
                        new GameStateOption { OptionText = "Hayır", NextState = "hayirOlayYeri" }
                    }
                }
            },
            {
                "olayYeri", new GameState
                {
                    StateText = "Polisle beraber parkta olay yerine geri döndünüz. Bir hatıra... Koşarak uzaklaşan kişinin elinde parlayan bir bıçak. Bıçağı buldun!",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Devam Et", NextState = "son" }
                    }
                }
            },
            {
                "hayirOlayYeri", new GameState
                {
                    StateText = "Tekrar oraya gidemem dedin. Daha fazla kanıt bulamadığın için TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "son", new GameState
                {
                    StateText = "Tekrar karakoldasın. Nezaretteyken avukatın geldi. Bıçağın üstündeki parmak izi fotoğrafta teşhis ettiğin kadınınmış. KURTULDUN!",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
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
