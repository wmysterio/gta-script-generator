using System;

namespace GTA.Plugins.Common {

    public abstract class SetupBase<T, K> where T : SetupBase<T, K>, new() where K : BasePointType<K>, new() {

        public delegate void RaceSetupHandler( T setup );

        public K points { get; private set; } = new K();
        public RaceCars cars { get; private set; } = new RaceCars();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool isOverrideWeather = false,
                      isOverrideRewardMoney = false,
                      isOverrideRewardRespect = false,
                      isOverrideStartTime = false,
                      isOverrideFadeMode = false,
                      isOverrideLockPlayer = false;

        internal int overridedRewardMoney = 0,
                     overridedRewardRespect = 0,
                     overridedStartTimeHours = 0,
                     overridedStartTimeMinutes = 0,
                     overridedFadeTime = 0;

        public Action BeforeCreate = null,
                      AfterCreate = null,
                      BeforePassed = null,
                      AfterPassed = null,
                      BeforeFailed = null,
                      AfterFailed = null;

        internal WeatherID overridedWeatherID = WeatherID.EXTRASUNNY_LA;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal SetupBase() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public T lock_player_on_start() { isOverrideLockPlayer = true; return ( T ) this; }
        public T fade_on_start( ushort maxTimeAs2500 ) { isOverrideFadeMode = true; overridedFadeTime = maxTimeAs2500 > 2500 ? 2500 : maxTimeAs2500; return ( T ) this; }
        public T set_weather( WeatherID weatherID ) { overridedWeatherID = weatherID; isOverrideWeather = true; return ( T ) this; }
        public T set_start_time( byte hour, byte minutes ) { overridedStartTimeHours = hour > 23 ? 23 : hour; overridedStartTimeMinutes = minutes > 59 ? 59 : minutes; isOverrideStartTime = true; return ( T ) this; }
        public T set_reward_money( int money ) { overridedRewardMoney = money; isOverrideRewardMoney = true; return ( T ) this; }
        public T set_reward_respect( int amount ) { overridedRewardRespect = amount; isOverrideRewardRespect = true; return ( T ) this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}