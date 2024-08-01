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
                        new GameStateOption { OptionText = "Yardım Et", NextState = "yardimEt" },
                        new GameStateOption { OptionText = "Öğrenmeden Geç ve Yürümeye Devam Et", NextState = "gecDevam" }
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
                        new GameStateOption { OptionText = "Reddet", NextState = "reddet" }
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
                    StateText = "Avukat talebini reddettin. Polis sorguya başladı... Öldürülen kadının ünlü bir sosyal medya fenomeni olduğunu öğrendin. Tanıyıp tanımadığın soruldu.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Evet", NextState = "evet" },
                        new GameStateOption { OptionText = "Hayır", NextState = "hayir" }
                    }
                }
            },
            {
                "reddet", new GameState
                {
                    StateText = "Polis sosyal medya hesaplarından öldürülen kadını takip ettiğini buldu. Hatta tüm fotoğraflarını beğenip birçoğuna yorum yaptığını keşfetti. Yalan söyledin, suçüstü yakalandın. TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "evet", new GameState
                {
                    StateText = "Sadece tanımakla kalmayıp kadının her paylaşımını da takip ettiğin ortaya çıktı. Polis seni stalker olmakla suçluyor... TUTUKLANDIN.",
                    Options = new[]
                    {
                        new GameStateOption { OptionText = "Başa Dön", NextState = "start" }
                    }
                }
            },
            {
                "hayir", new GameState
                {
                    StateText = "Polis sosyal medya hesaplarından öldürülen kadını takip ettiğini buldu. Hatta tüm fotoğraflarını beğenip birçoğuna yorum yaptığını keşfetti. Yalan söyledin, suçüstü yakalandın. TUTUKLANDIN.",
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