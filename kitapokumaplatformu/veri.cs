using System.Collections.Generic;

namespace KitapOkumaSistemi
{
    public static class veri
    {
        // Kitap isimleri ve içerikleri
        public static List<string> kitapIsimleri = new List<string>
        {
            "Kitap 1: Yüzyılın En Güzel Kitabı",
            "Kitap 2: Karanlıkta Kal",
            "Kitap 3: Geceyi Beklerken",
            "Kitap 4: Zamanın Sınırları"
        };

        public static Dictionary<string, string> kitapIcerikleri = new Dictionary<string, string>
        {
            {
                "Kitap 1: Yüzyılın En Güzel Kitabı",
                "Kitap 1 İçeriği: Bu kitap, yüzyılın en önemli olaylarını anlatmaktadır. " +
                "İlk olarak, dünyanın dört bir yanındaki toplulukların bir araya geldiği büyük bir zirveye odaklanır. " +
                "\n\nZirvede, liderler kendi uluslarını temsil ederken, insanlar barış ve refah için bir araya gelir. " +
                "Birçok farklı dilde yapılan konuşmalar, kültürel farklılıkları gözler önüne serer. " +
                "İkinci bölümde, zirvenin öncesindeki hazırlıklar ve gerilimli süreçler detaylı bir şekilde ele alınır. " +
                "\n\nBölümde, bazı liderlerin kararları nasıl şekillendirdiği, planların nasıl uygulamaya konduğu anlatılmaktadır. " +
                "Kitap, zirvenin ardından yaşanan olayların özetini yaparak, toplumları nasıl etkilediğini tartışır. " +
                "Yüzyılın en önemli olaylarına dair her detay, anlatıcının derinlemesine bakışıyla ele alınır."
            },
            {
                "Kitap 2: Karanlıkta Kal",
                "Kitap 2 İçeriği: Karanlık bir dünyada bir kahramanın serüvenini anlatan bu kitap, insanın en karanlık yönleriyle yüzleşmesini konu alır. " +
                "Kahramanımız, içinde bulunduğu karanlık dünyadan kaçmak için bir yol arayışına girer. " +
                "Bölüm 1: Kahramanın geçmişi ve nasıl bu karanlık dünyaya düştüğü anlatılmaktadır. " +
                "\n\nKahraman, ailesini kaybetmiş ve yalnız bir şekilde yaşama tutunmaya çalışmaktadır. Ancak, her adımında karanlık güçlerle mücadele etmek zorunda kalır. " +
                "Bölüm 2: Karanlık dünyanın derinliklerine inmeye karar verir ve burada karşılaştığı zorluklarla başa çıkmaya çalışır. " +
                "\n\nBölüm 3: Kahraman, bir grup insanla tanışır ve birlikte bu karanlık dünyadan çıkmak için mücadele ederler. Ancak, içlerinden bazıları ihanete uğrayacak ve kahraman zor bir karar vermek zorunda kalacaktır."
            },
            {
                "Kitap 3: Geceyi Beklerken",
                "Kitap 3 İçeriği: Bir grup insanın geceyi birlikte beklemesini konu alır. Kitap, gecenin karanlığında kaybolmuş bir kasabada geçer. " +
                "Başlangıçta, kasaba sakinleri gündüzün sıcaklığından uzaklaşarak geceyi beklemektedir. Ancak, gece ilerledikçe, bir dizi esrarengiz olay başlar. " +
                "\n\nBir grup insan, geceyi birlikte geçirmek için kasabanın meydanında toplanır. Geceyi beklerken, kasabaya gelen yabancı bir adam ve onun anlattığı hikayeler herkesin dikkatini çeker. " +
                "Bölüm 1: Yabancı adamın kasabaya gelişi ve kasaba halkı üzerinde bıraktığı etkiler anlatılmaktadır. " +
                "\n\nBölüm 2: Adamın geçmişi, kasaba halkına tehdit oluşturacak şekilde ortaya çıkar. Yavaşça kasabanın karanlık sırları gün yüzüne çıkar."
            },
            {
                "Kitap 4: Zamanın Sınırları",
                "Kitap 4 İçeriği: Zamanın ve sınırların ötesine geçmeyi anlatan bir fantastik roman. Kitap, zamanın kontrolünü elinde tutan bir grup insanın hikayesini konu alır. " +
                "Bölüm 1: Zamanın sırrını keşfeden bir grup bilim insanı, geçmişi değiştirmek için çeşitli deneyler yapmaktadır. " +
                "\n\nAncak, zamanla oynanması, bazı beklenmedik sonuçlara yol açar. Geçmişin değişmesi, geleceği tehdit etmeye başlar. " +
                "Bölüm 2: Zamanın kontrolünü ele geçiren bir kişi, evrenin sınırlarına kadar uzanmak istemektedir. " +
                "\n\nAncak bu arayışında, zamanın bükülmesi, evrenin düzenini bozacak kadar tehlikeli hale gelir. Kahramanlar, zamanı ve evreni korumak için mücadele etmeye karar verirler."
            }
        };
    }
}
