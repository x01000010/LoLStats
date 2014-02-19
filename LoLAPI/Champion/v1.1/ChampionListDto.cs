namespace LoLAPI.Champion.v1._1
{
    public class ChampionListDto
    {
        private ChampionDto[] champions;

        public ChampionListDto()
        {
            champions = null;
        }

        public ChampionDto[] Champions
        {
            get { return champions; }
            set { champions = value; }
        }
    }
}