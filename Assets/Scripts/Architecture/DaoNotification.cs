namespace Architecture
{
    public abstract class DaoNotification
    {
        public const string ButtonClick = "button.click";
        public const string ButtonEnterHover = "button.hover.enter";
        public const string ButtonExitHover = "button.hover.exit";

        public const string LevelComplete = "level.complete";
        public const string LevelStart = "level.start";
        
        public const string ViewLoad = "view.load";

        public const string HealthUpdate = "health.update";
        
    }
}
