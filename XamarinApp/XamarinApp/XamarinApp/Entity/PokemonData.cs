using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.Models;

namespace XamarinApp.Entity
{
    public static class PokemonData
    {
        public static IList<Animal> Pokemons { get; private set; }

        static PokemonData() {
            Pokemons = new List<Animal>();

            Pokemons.Add(new Animal
            {
                Name = "Pikachu",
                Location = "Nhật Bản",
                Details = "Pikachu là một loài gặm nhấm với thân hình lùn và nhỏ. Pikachu rất dễ nhận ra bởi thân hình toàn màu vàng, với đôi tai dài và những sọc đen sau lưng, cạnh cái đuôi như tia điện xẹt.Pikachu sống thành đàn trong những khu rừng. Chúng tích trữ nguồn điện bằng hai đốm trên má. Dù hai đốm đó là rất nhỏ, nhưng mọi người thường cho rằng chúng có thể tích được một lượng điện năng khổng lồ.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/thumb/f/f7/Sugimoris025.png/220px-Sugimoris025.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Arceus",
                Location = "Nhật Bản",
                Details = "Arceus là một Pokémon huyền ảo có thể có được đầu tiên trong trò chơi Pokémon Diamond và Pearl. Trong truyền thuyết của loạt game Pokémon, Arceus là vị thần sáng tạo đã tạo ra vũ trụ của trò chơi. Sau khi phát hành, Arceus đã được đón nhận tương đối thuận lợi, với việc nó được bình chọn là Pokémon yêu thích nhất trong cuộc thăm dò ý kiến người hâm mộ Nhật Bản do The Pokémon Company thực hiện.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/thumb/5/53/Pok%C3%A9mon_official_artwork_of_Arceus.png/220px-Pok%C3%A9mon_official_artwork_of_Arceus.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Mizugorou",
                Location = "Nhật Bản",
                Details = "Mizugorou, được gọi là Pokémon Cá đầm lầy, là Pokémon nhỏ màu xanh với cái vây lớn trên đầu cho phép chúng cảm nhận được các chuyển động trong không khí và nước, hoạt động như một radar.[2] Khi ở dưới nước, chúng sử dụng mang màu cam, nhọn trên má để thở trong khi sử dụng vây đuôi lớn để tự đẩy mình.[3][4] Chúng cực kỳ khỏe mạnh, có thể nâng hoặc nghiền nát những tảng đá lớn.[3][5] Khi ngủ, chúng vùi mình trong lớp bùn lầy ở mép nước. Mizugorou và tiến hóa sống trong đầm lầy hoặc vùng đất ngập nước khác, sâu bên trong các hòn đảo bị cô lập, vì chúng không thích các hồ nước ngọt và ao hồ.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/2/22/Pok%C3%A9mon_Mudkip_art.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Gekkouga",
                Location = "Nhật Bản",
                Details = "Gekkouga là một sinh vật trông giống ếch được sắp xếp hợp lý với làn da màu xanh sẫm và phần dưới màu be, với các chi dài và thân hình gầy gò đặc biệt gợi nhớ đến ếch cây. Những gì giống như một chiếc khăn màu hồng thực sự là lưỡi tiền sử của nó quấn quanh đầu của nó. Hai phần lồi ra giống như tai kéo dài từ hai bên đầu và kết nối với một cấu trúc giống như sừng nhỏ hơn ở giữa bằng cách thắt vải màu xanh lam.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/thumb/d/d3/%E1%BA%A2nh_minh_h%E1%BB%8Da_Gekkouga_ch%C3%ADnh_th%E1%BB%A9c.png/330px-%E1%BA%A2nh_minh_h%E1%BB%8Da_Gekkouga_ch%C3%ADnh_th%E1%BB%A9c.png"
            });

            Pokemons.Add(new Animal
            {
                Name = "Mimikkyu",
                Location = "Nhật Bản",
                Details = "Mimikkyu là một Pokémon nhỏ, chỉ cao 8 inch và được ẩn giấu gần như hoàn toàn bên dưới lớp ngụy trang.[1] Nó có đôi mắt đen láy có thể nhìn thấy qua lớp vỏ ngụy trang của nó, và một bàn chân hoặc phần dưới cơ thể không rõ ràng có thể được nhìn thấy ở viền dưới của lớp ngụy trang. Nó đôi khi sẽ mở rộng một phần phụ màu đen từ bên dưới phần ngụy trang; ngụy trang có đôi mắt đen, má đỏ, cái miệng đen ngoằn ngoèo, một cây gậy hình tia sét giống như cái đuôi và đôi tai có màu đen nằm trên đỉnh. Theo trang web chính thức của Pokémon, Mimikyu cô đơn khủng khiếp và trong nỗ lực mô phỏng sự nổi tiếng của Pikachu, nó mặc trang phục giống Pikachu để kết bạn.[2] Mimikyu bị hấp dẫn vào những vùng tối hoặc thiếu sáng, và sức khỏe của nó sẽ suy giảm nếu tiếp xúc với ánh sáng mặt trời.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/2/23/Pok%C3%A9mon_Mimikyu_art.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Bursyamo",
                Location = "Nhật Bản",
                Details = "Bursyamo, được gọi là Pokémon Rực lửa, phát triển từ Wakasyamo ở cấp 36, và là hình thức cuối cùng của Achamo. Bursyamo xuất hiện như thể nó đang mặc một chiếc áo khoác không tay trên thân. Nó có một đỉnh trên đầu với hai điểm, giống như chữ V. Nó cũng có phần lông dài phía sau đầu và khuôn mặt nhỏ gần như phủ đầy lông. Đôi chân mạnh mẽ, cơ bắp của nó giúp nó nhảy lên một tòa nhà chọc trời chỉ bằng một cú đá và dễ dàng.[2] Nó có thể khiến ngọn lửa phun ra từ cổ tay và mắt cá chân, che kín bàn chân hoặc nắm đấm. Bursyamo cũng có các mũi nhọn trên mắt cá chân tương tự như được sử dụng trong đấu đá gà. Nó cũng có thể tung ra một cú đá bốc lửa vào đối thủ.[3] Cứ sau vài năm, những chiếc lông cũ của nó lại bị đốt cháy và những chiếc lông mới, dẻo dai mọc lại ở vị trí của chúng.[4] Một thiết kế ý tưởng ban đầu của Bursyamo đã kết hợp với Latias và có một huấn luyện viên trên lưng.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/f/f8/Pok%C3%A9mon_Blaziken_art.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Chicorita",
                Location = "Nhật Bản",
                Details = "Chicorita, thường không thể tìm thấy trong tự nhiên, có thể được tìm thấy bằng cách quét mã QR khi ở trên Đảo Melemele. Chicorita đã xuất hiện trong một số trò chơi khác. Trong cả Siêu Smash Bros. Melee và Super Smash Bros. Brawl Brawl, Chicorita có thể được sử dụng để tấn công đối thủ bằng chiêu Lá Cắt khi được thả ra từ bóng chứa Pokémon.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/1/1a/Pok%C3%A9mon_Chikorita_art.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Fushigibana",
                Location = "Nhật Bản",
                Details = "Được tạo bởi Ken Sugimori, Fushigibana lần đầu tiên xuất hiện trong các trò chơi video Pokémon Red và Blue và các phần tiếp theo, sau đó xuất hiện trong nhiều mặt hàng khác nhau, tựa đề spinoff và phim hoạt hình và chuyển thể bản in của nhượng quyền thương mại. Fushigibana có khả năng Tiến Hóa Mega, cho phép nó biến thành Mega Fushigibana. Nó tiến hóa từ Fushigisou và là dạng tiến hóa cuối cùng của Fushigidane.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/f/fb/Venusaur_003.png"
            });
            Pokemons.Add(new Animal
            {
                Name = "Eievui",
                Location = "Nhật Bản",
                Details = "Được biết đến như là Pokémon Tiến hóa trong các trò chơi Pokémon và anime,[2] Eievui là một Pokémon giống mèo tai thỏ với gen di truyền không ổn định, cho phép nó tiến hóa thành một trong tám Pokémon khác nhau, được gọi một cách không chính thức là Eeveelutions, tuỳ thuộc vào tình hình và điều kiện tiến hóa. Ba tiến hóa đầu tiên, Vaporeon, Jolteon và Flareon, đã được giới thiệu cùng với Eievui trong Pokémon Red and Blue. Năm hình thái tiến hóa khác đã được giới thiệu trong các trò chơi Pokémon là Espeon, Umbreon, Leafeon, Glaceon và Sylveon.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/a/a9/Pok%C3%A9mon_Eevee_art.png"
            });

        }
    }
}
