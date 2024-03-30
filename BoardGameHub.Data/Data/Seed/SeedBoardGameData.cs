using BoardGameHub.Data.Data.DataModels;
using System.Data.SqlTypes;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedBoardgameData
    {
        public SeedBoardgameData()
        {
            SeedBoardgames();
        }

        public Boardgame DuneBoardgame { get; set; }
        public Boardgame TerraformingMarsBoardgame { get; set; }
        public Boardgame CatanBoardgame { get; set; }
        public Boardgame PhotosynthesisBoardgame { get; set; }
        public Boardgame TicketToRideBoardgame { get; set; }
        public Boardgame GloomhavenBoardgame { get; set; }
        public Boardgame MysteriumBoardgame { get; set; }
        public Boardgame EverdellBoardgame { get; set; }
        public Boardgame MonopolyBulgariaBoardgame { get; set; }
        public Boardgame PandemicBoardgame { get; set; }
        public Boardgame BrassBirminghamBoardgame { get; set; }
        public Boardgame ArkNovaBoardgame { get; set; }
        public Boardgame ScytheBoardgame { get; set; }
        public Boardgame NemesisBoardgame { get; set; }
        public Boardgame WingspanBoardgame { get; set; }
        public Boardgame CascadiaBoardgame { get; set; }
        public Boardgame CodenamesBoardgame { get; set; }
        public Boardgame DixitBoardgame { get; set; }
        public Boardgame ExplodingKittensBoardgame { get; set; }
        public Boardgame DecryptoBoardgame { get; set; }
        public Boardgame EclipseSecondDawnForTheGalaxyBoardgame { get; set; }

        private void SeedBoardgames()
        {
            DuneBoardgame = new Boardgame()
            {
                Id = 1,
                Name = "Dune: Imperium",
                AveragePlayingTime = 90,
                Description = "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.",
                Difficulty = 3,
                ImageUrl = "~/assets/games/Dune_Imperium_card.jpg",
                YearPublished = 2020,
                PriceInShop = 90.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            TerraformingMarsBoardgame = new Boardgame()
            {
                Id = 2,
                Name = "Terraforming Mars",
                AveragePlayingTime = 120,
                Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                Difficulty = 3.5,
                ImageUrl = "~/assets/games/Terraforming_Mars_card.jpg",
                YearPublished = 2016,
                PriceInShop = 100.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            CatanBoardgame = new Boardgame()
            {
                Id = 3,
                Name = "Catan",
                AveragePlayingTime = 90,
                Description = "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Catan_card.jpg",
                YearPublished = 1995,
                PriceInShop = 50.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            PhotosynthesisBoardgame = new Boardgame()
            {
                Id = 4,
                Name = "Photosynthesis",
                AveragePlayingTime = 60,
                Description = "The sun shines brightly on the canopy of the forest, and the trees use this wonderful energy to grow and develop their beautiful foliage. Sow your crops wisely and the shadows of your growing trees could slow your opponents down, but don't forget that the sun revolves around the forest. Welcome to the world of Photosynthesis, the green strategy board game!",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Photosynthesis_card.jpg",
                YearPublished = 2017,
                PriceInShop = 45.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            TicketToRideBoardgame = new Boardgame()
            {
                Id = 5,
                Name = "Ticket to Ride",
                AveragePlayingTime = 60,
                Description = "With elegantly simple gameplay, Ticket to Ride can be learned in under 15 minutes. Players collect cards of various types of train cars they then use to claim railway routes in North America. The longer the routes, the more points they earn. Additional points come to those who fulfill Destination Tickets – goal cards that connect distant cities; and to the player who builds the longest continuous route.",
                Difficulty = 1.5,
                ImageUrl = "~/assets/games/Ticket_To_Ride_card.jpg",
                YearPublished = 2004,
                PriceInShop = 70.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            GloomhavenBoardgame = new Boardgame()
            {
                Id = 6,
                Name = "Gloomhaven",
                AveragePlayingTime = 120,
                Description = "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make. This is a game with a persistent and changing world that is ideally played over many game sessions. After a scenario, players will make decisions on what to do, which will determine how the story continues, kind of like a “Choose Your Own Adventure” book. Playing through a scenario is a cooperative affair where players will fight against automated monsters using an innovative card system to determine the order of play and what a player does on their turn.",
                Difficulty = 4,
                ImageUrl = "~/assets/games/Gloomhaven_card.jpg",
                YearPublished = 2017,
                PriceInShop = 250.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = true
            };

            MysteriumBoardgame = new Boardgame()
            {
                Id = 7,
                Name = "Mysterium",
                AveragePlayingTime = 45,
                Description = "In the 1920s, Mr. MacDowell, a gifted astrologer, immediately detected a supernatural being upon entering his new house in Scotland. He gathered eminent mediums of his time for an extraordinary séance, and they have seven hours to make contact with the ghost and investigate any clues that it can provide to unlock an old mystery.Unable to talk, the amnesiac ghost communicates with the mediums through visions, which are represented in the game by illustrated cards. The mediums must decipher the images to help the ghost remember how he was murdered: Who did the crime? Where did it take place? Which weapon caused the death? The more the mediums cooperate and guess well, the easier it is to catch the right culprit.",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Mysterium_card.jpg",
                YearPublished = 2015,
                PriceInShop = 70.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 7,
                IsReserved = false,
                IsUpcoming = false
            };

            EverdellBoardgame = new Boardgame()
            {
                Id = 8,
                Name = "Everdell",
                AveragePlayingTime = 60,
                Description = "Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. You will be the leader of a group of critters intent on just such a task. There are buildings to construct, lively characters to meet, events to host—you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises?",
                Difficulty = 2.8,
                ImageUrl = "~/assets/games/Everdell_card.jpg",
                YearPublished = 2018,
                PriceInShop = 110M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            MonopolyBulgariaBoardgame = new Boardgame()
            {
                Id = 9,
                Name = "Monopoly-Bulgaria",
                AveragePlayingTime = 90,
                Description = "Know your motherland, to love it. But what if you could own a small part of Bulgaria for yourself? This is possible with the special edition of Monopoly - Bulgaria is wonderful. Buy one of the most majestic sights in our country - the unique Stobski pyramids, the National Palace of Culture, the temple-monument \"St. Alexander Nevsky\". Take a walk along some of our most beautiful hiking trails - go inside Devetashka Cave, cross the Devil's Bridge and connect with nature through the Paneurhythmy around the Seven Rila Lakes. The rules are well known to everyone - build hotels and houses to develop your properties, try your luck with the BANK or CHANCE cards. Roll the dice and discover the wonders of Bulgaria as you fight for victory.",
                Difficulty = 1.5,
                ImageUrl = "~/assets/games/Monopoly_Bulgaria_card.jpg",
                YearPublished = 2021,
                PriceInShop = 55.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 6,
                IsReserved = false,
                IsUpcoming = false
            };

            PandemicBoardgame = new Boardgame()
            {
                Id = 10,
                Name = "Pandemic",
                AveragePlayingTime = 45,
                Description = "In Pandemic, several virulent diseases have broken out simultaneously all over the world! The players are disease-fighting specialists whose mission is to treat disease hotspots while researching cures for each of four plagues before they get out of hand. The game board depicts several major population centers on Earth. On each turn, a player can use up to four actions to travel between cities, treat infected populaces, discover a cure, or build a research station. A deck of cards provides the players with these abilities, but sprinkled throughout this deck are Epidemic! cards that accelerate and intensify the diseases' activity. A second, separate deck of cards controls the \"normal\" spread of the infections.",
                Difficulty = 2.5,
                ImageUrl = "~/assets/games/Pandemic_card.jpg",
                YearPublished = 2008,
                PriceInShop = 45.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            BrassBirminghamBoardgame = new Boardgame()
            {
                Id = 11,
                Name = "Brass: Birmingham",
                AveragePlayingTime = 90,
                Description = "Brass: Birmingham is an economic strategy game sequel to Martin Wallace' 2007 masterpiece, Brass. Brass: Birmingham tells the story of competing entrepreneurs in Birmingham during the industrial revolution, between the years of 1770-1870. It offers a very different story arc and experience from its predecessor. As in its predecessor, you must develop, build, and establish your industries and network, in an effort to exploit low or high market demands. The game is played over two halves: the canal era (years 1770-1830) and the rail era (years 1830-1870). To win the game, score the most VPs. VPs are counted at the end of each half for the canals, rails and established (flipped) industry tiles.",
                Difficulty = 4,
                ImageUrl = "~/assets/games/Brass_Birmingham_card.jpg",
                YearPublished = 2018,
                PriceInShop = 150.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            ArkNovaBoardgame = new Boardgame()
            {
                Id = 12,
                Name = "Ark Nova",
                AveragePlayingTime = 120,
                Description = "In Ark Nova, you will plan and design a modern, scientifically managed zoo. With the ultimate goal of owning the most successful zoological establishment, you will build enclosures, accommodate animals, and support conservation projects all over the world. Specialists and unique buildings will help you in achieving this goal.\r\nEach player has a set of five action cards to manage their gameplay, and the power of an action is determined by the slot the card currently occupies. The cards in question are:\r\n\r\nCARDS: Allows you to gain new zoo cards (animals, sponsors, and conservation project cards).\r\nBUILD: Allows you to build standard or special enclosures, kiosks, and pavilions.\r\nANIMALS: Allows you to accommodate animals in your zoo.\r\nASSOCIATION: Allows your association workers to carry out different tasks.\r\nSPONSORS: Allows you to play a sponsor card in your zoo or to raise money.\r\n255 cards featuring animals, specialists, special enclosures, and conservation projects, each with a special ability, are at the heart of Ark Nova. Use them to increase the appeal and scientific reputation of your zoo and collect conservation points.",

                Difficulty = 3.7,
                ImageUrl = "~/assets/games/Ark_Nova_card.jpg",
                YearPublished = 2021,
                PriceInShop = 135.00M,
                MinimumPlayersAllowedToPlay =1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = true
            };

            ScytheBoardgame = new Boardgame()
            {
                Id = 13,
                Name = "Scythe",
                AveragePlayingTime = 90,
                Description = "It is a time of unrest in 1920s Europa. The ashes from the first great war still darken the snow. The capitalistic city-state known simply as “The Factory”, which fueled the war with heavily armored mechs, has closed its doors, drawing the attention of several nearby countries.\r\nScythe is an engine-building game set in an alternate-history 1920s period. It is a time of farming and war, broken hearts and rusted gears, innovation and valor. In Scythe, each player represents a character from one of five factions of Eastern Europe who are attempting to earn their fortune and claim their faction's stake in the land around the mysterious Factory. Players conquer territory, enlist new recruits, reap resources, gain villagers, build structures, and activate monstrous mechs.",

                Difficulty = 3.5,
                ImageUrl = "~/assets/games/Scythe_card.jpg",
                YearPublished = 2016,
                PriceInShop = 165.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            NemesisBoardgame = new Boardgame()
            {
                Id = 14,
                Name = "Nemesis",
                AveragePlayingTime = 150,
                Description = "Playing Nemesis will take you into the heart of sci-fi survival horror in all its terror. A soldier fires blindly down a corridor, trying to stop the alien advance. A scientist races to find a solution in his makeshift lab. A traitor steals the last escape pod in the very last moment. Intruders you meet on the ship are not only reacting to the noise you make but also evolve as the time goes by. The longer the game takes, the stronger they become. During the game, you control one of the crew members with a unique set of skills, personal deck of cards, and individual starting equipment. These heroes cover all your basic SF horror needs. For example, the scientist is great with computers and research, but will have a hard time in combat. The soldier, on the other hand...",

                Difficulty = 3.5,
                ImageUrl = "~/assets/games/Nemesis_card.jpg",
                YearPublished = 2018,
                PriceInShop = 200.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            WingspanBoardgame = new Boardgame()
            {
                Id = 15,
                Name = "Wingspan",
                AveragePlayingTime = 60,
                Description = "Wingspan is a competitive, medium-weight, card-driven, engine-building board game from Stonemaier Games. It's designed by Elizabeth Hargrave and features over 170 birds illustrated by Beth Sobel, Natalia Rojas, and Ana Maria Martinez.\r\n\r\nYou are bird enthusiasts—researchers, bird watchers, ornithologists, and collectors—seeking to discover and attract the best birds to your network of wildlife preserves. Each bird extends a chain of powerful combinations in one of your habitats (actions). These habitats focus on several key aspects of growth:\r\n\r\nGain food tokens via custom dice in a birdfeeder dice tower\r\nLay eggs using egg miniatures in a variety of colors\r\nDraw from hundreds of unique bird cards and play them\r\nThe winner is the player with the most points after 4 rounds.",

                Difficulty = 2.5,
                ImageUrl = "~/assets/games/Wingspan_card.jpg",
                YearPublished = 2019,
                PriceInShop = 100.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            CascadiaBoardgame = new Boardgame()
            {
                Id = 16,
                Name = "Cascadia",
                AveragePlayingTime = 45,
                Description = "Cascadia is a puzzly tile-laying and token-drafting game featuring the habitats and wildlife of the Pacific Northwest.\r\n\r\nIn the game, you take turns building out your own terrain area and populating it with wildlife. You start with three hexagonal habitat tiles (with the five types of habitat in the game), and on a turn you choose a new habitat tile that's paired with a wildlife token, then place that tile next to your other ones and place the wildlife token on an appropriate habitat. (Each tile depicts 1-3 types of wildlife from the five types in the game, and you can place at most one tile on a habitat.) Four tiles are on display, with each tile being paired at random with a wildlife token, so you must make the best of what's available — unless you have a nature token to spend so that you can pick your choice of each item.",

                Difficulty = 1.5,
                ImageUrl = "~/assets/games/Cascadia_card.jpg",
                YearPublished = 2021,
                PriceInShop = 72.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            CodenamesBoardgame = new Boardgame()
            {
                Id = 17,
                Name = "Codenames",
                AveragePlayingTime = 15,
                Description = "Two rival spymasters know the secret identities of 25 agents. Their teammates know the agents only by their codenames — single-word labels like \"disease\", \"Germany\", and \"carrot\". Yes, carrot. It's a legitimate codename. Each spymaster wants their team to identify their agents first...without uncovering the assassin by mistake.\r\n\r\nIn Codenames, two teams compete to see who can make contact with all of their agents first. Lay out 25 cards, each bearing a single word. The spymasters look at a card showing the identity of each card, then take turns clueing their teammates. A clue consists of a single word and a number, with the number suggesting how many cards in play have some association to the given clue word. The teammates then identify one agent they think is on their team; if they're correct, they can keep guessing up to the stated number of times; if the agent belongs to the opposing team or is an innocent bystander, the team's turn ends; and if they fingered the assassin, they lose the game.\r\n\r\nSpymasters continue giving clues until one team has identified all of their agents or the assassin has removed one team from play.",

                Difficulty = 1,
                ImageUrl = "~/assets/games/Codenames_card.jpg",
                YearPublished = 2015,
                PriceInShop = 40.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 8,
                IsReserved = false,
                IsUpcoming = false
            };

            DixitBoardgame = new Boardgame()
            {
                Id = 18,
                Name = "Dixit",
                AveragePlayingTime = 30,
                Description = "Each turn in Dixit, one player is the storyteller, chooses one of the six cards in their hand, then makes up a sentence based on that card's image and says it out loud without showing the card to the other players. Each other player then selects the card in their hand that best matches the sentence and gives the selected card to the storyteller, without showing it to anyone else.\r\n\r\nThe storyteller shuffles their card with all of the received cards, then reveals all of these cards. Each player other than the storyteller then secretly guesses which card belongs to the storyteller. If nobody or everybody guesses the correct card, the storyteller scores 0 points, and each other player scores 2 points. Otherwise, the storyteller and whoever found the correct answer score 3 points. Additionally, the non-storyteller players score 1 point for every vote received by their card.\r\n\r\nThe game ends when the deck is empty or if a player has scored at least 30 points. In either case, the player with the most points wins.\r\n\r\nThe Dixit base game and each expansion contains 84 cards, and the cards can be mixed together as desired.",

                Difficulty = 1.2,
                ImageUrl = "~/assets/games/Dixit_card.jpg",
                YearPublished = 2008,
                PriceInShop = 55.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 8,
                IsReserved = false,
                IsUpcoming = false
            };

            ExplodingKittensBoardgame = new Boardgame()
            {
                Id = 19,
                Name = "Exploding Kittens",
                AveragePlayingTime = 15,
                Description = "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.\r\n\r\nThe game gets more and more intense with each card you draw because fewer cards left in the deck means a greater chance of drawing the kitten and exploding in a fiery ball of feline hyperbole.",

                Difficulty = 1,
                ImageUrl = "~/assets/games/Exlpoding_Kittens_card.jpg",
                YearPublished = 2015,
                PriceInShop = 45.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            DecryptoBoardgame = new Boardgame()
            {
                Id = 20,
                Name = "Decrypto",
                AveragePlayingTime = 30,
                Description = "Players compete in two teams in Decrypto, with each trying to correctly interpret the coded messages presented to them by their teammates while cracking the codes they intercept from the opposing team.\r\n\r\nIn more detail, each team has their own screen, and in this screen they tuck four cards in pockets numbered 1-4, letting everyone on the same team see the words on these cards while hiding the words from the opposing team. In the first round, each team does the following: One team member takes a code card that shows three of the digits 1-4 in some order, e.g., 4-2-1. They then give a coded message that their teammates must use to guess this code. For example, if the team's four words are \"pig\", \"candy\", \"tent\", and \"son\", then I might say \"Sam-striped-pink\" and hope that my teammates can correctly map those words to 4-2-1. If they guess correctly, great; if not, we receive a black mark of failure.",

                Difficulty = 1.8,
                ImageUrl = "~/assets/games/Decrypto_card.jpg",
                YearPublished = 2018,
                PriceInShop = 40.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 8,
                IsReserved = false,
                IsUpcoming = false
            };

            EclipseSecondDawnForTheGalaxyBoardgame = new Boardgame()
            {
                Id = 21,
                Name = "Eclipse: Second Dawn for the Galaxy",
                AveragePlayingTime = 150,
                Description = "A game of Eclipse places you in control of a vast interstellar civilization, competing for success with its rivals. You explore new star systems, research technologies, and build spaceships with which to wage war. There are many potential paths to victory, so you need to plan your strategy according to the strengths and weaknesses of your species, while paying attention to the other civilizations' endeavors.\r\n\r\nEclipse: Second Dawn for the Galaxy is a revised and upgraded version of the Eclipse base game that debuted in 2011 that features:\r\n\r\nNew graphic design, while maintaining the acclaimed symbology of the first edition\r\nA full line of Ship Pack 1 miniatures\r\nNew miniatures for ancients, GCDS, orbitals, and more\r\nCustom plastic inlays\r\nCustom combat dice\r\nFine-tuned gameplay",

                Difficulty = 3.7,
                ImageUrl = "~/assets/games/Eclipse_card.jpg",
                YearPublished = 2020,
                PriceInShop = 275.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 6,
                IsReserved = false,
                IsUpcoming = true
            };
        }
    }
}
