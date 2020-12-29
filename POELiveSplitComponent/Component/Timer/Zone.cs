using System.Collections.Generic;

namespace POELiveSplitComponent.Component.Timer
{
    public class Zone : IZone
    {
        public enum IconType { Wp, NoWp, Town }

        public static readonly List<Zone> ZONES;

        private static readonly Dictionary<Zone, Zone> REQUIRED;

        public static readonly Dictionary<IZone, IconType> ICONTYPES;

        static Zone()
        {
            ZONES = new List<Zone>();
            REQUIRED = new Dictionary<Zone, Zone>();
            ICONTYPES = new Dictionary<IZone, IconType>();

            Zone kitavaPart1Kill = new Zone("The Cathedral Rooftop", 1);
            Zone act6Home = new Zone("라이온아이 초소", 2);
            Zone act7Home = new Zone("The Bridge Encampment", 2);
            Zone sarnRamparts = new Zone("The Sarn Ramparts", 2);
            Zone act8Home = new Zone("The Sarn Encampment", 2);
            Zone bloodAqueduct = new Zone("The Blood Aqueduct", 2);
            Zone act9Home = new Zone("Highgate", 2);
            Zone act10Home = new Zone("Oriath Docks", 2);

            add(new Zone("라이온아이 초소", 1), IconType.Town);
            add(new Zone("해안 지대", 1), IconType.Wp);
            add(new Zone("물결섬", 1), IconType.NoWp);
            add(new Zone("갯벌", 1), IconType.NoWp);
            add(new Zone("물에 잠긴 길", 1), IconType.Wp);
            add(new Zone("물에 잠긴 심연", 1), IconType.NoWp);
            add(new Zone("바위턱", 1), IconType.Wp);
            add(new Zone("고개", 1), IconType.Wp);
            add(new Zone("수용소 하층", 1), IconType.Wp);
            add(new Zone("수용소 상층", 1), IconType.NoWp);
            add(new Zone("죄수의 문", 1), IconType.Wp);
            add(new Zone("배들의 묘지", 1), IconType.Wp);
            add(new Zone("배들의 묘지의 동굴", 1), IconType.NoWp);
            add(new Zone("진노의 암굴", 1), IconType.Wp);
            add(new Zone("분노의 암굴", 1), IconType.NoWp);
            add(new Zone("남쪽 숲", 1), IconType.Wp);
            add(new Zone("숲 야영지", 1), IconType.Town);
            add(new Zone("강변길", 1), IconType.Wp);
            add(new Zone("서쪽 숲", 1), IconType.Wp);
            add(new Zone("거미의 둥지", 1), IconType.NoWp);
            add(new Zone("버려진 경작지", 1), IconType.NoWp);
            add(new Zone("갈림길", 1), IconType.Wp);
            add(new Zone("죄악의 방 1층", 1), IconType.Wp);
            add(new Zone("죄악의 방 2층", 1), IconType.NoWp);
            add(new Zone("몰락한 성소 유적", 1), IconType.NoWp);
            add(new Zone("부서진 다리", 1), IconType.Wp);
            add(new Zone("습지대", 1), IconType.Wp);
            add(new Zone("바알 유적", 1), IconType.NoWp);
            add(new Zone("북쪽 숲", 1), IconType.Wp);
            add(new Zone("암굴", 1), IconType.Wp);
            add(new Zone("고대 피라미드", 1), IconType.NoWp);
            add(new Zone("사안 시내", 1), IconType.Wp);
            add(new Zone("사안 야영지", 1), IconType.Town);
            add(new Zone("빈민가", 1), IconType.NoWp);
            add(new Zone("화장터", 1), IconType.Wp);
            add(new Zone("하수도", 1), IconType.Wp);
            add(new Zone("장터", 1), IconType.Wp);
            add(new Zone("지하묘지", 1), IconType.NoWp);
            add(new Zone("전쟁터", 1), IconType.Wp);
            add(new Zone("항구", 1), IconType.Wp);
            add(new Zone("솔라리스의 사원 1층", 1), IconType.Wp);
            add(new Zone("솔라리스의 사원 2층", 1), IconType.Wp);
            add(new Zone("칠흑의 군단 주둔지", 1), IconType.Wp);
            add(new Zone("루나리스 사원 1층", 1), IconType.Wp);
            add(new Zone("루나리스 사원 2층", 1), IconType.NoWp);
            add(new Zone("황실 정원", 1), IconType.Wp);
            add(new Zone("도서관", 1), IconType.Wp);
            add(new Zone("신의 셉터", 1), IconType.Wp);
            add(new Zone("신의 셉터 상층", 1), IconType.NoWp);
            add(new Zone("수로", 1), IconType.Wp);
            add(new Zone("하이게이트", 1), IconType.Town);
            add(new Zone("말라붙은 호수", 1), IconType.NoWp);
            add(new Zone("광산 1층", 1), IconType.NoWp);
            add(new Zone("광산 2층", 1), IconType.NoWp);
            add(new Zone("수정 광맥", 1), IconType.Wp);
            add(new Zone("다레소의 꿈", 1), IconType.NoWp);
            add(new Zone("대 투기장", 1), IconType.Wp);
            add(new Zone("카옴의 꿈", 1), IconType.NoWp);
            add(new Zone("카옴의 요새", 1), IconType.Wp);
            add(new Zone("짐승의 소굴 1층", 1), IconType.NoWp);
            add(new Zone("짐승의 소굴 2층", 1), IconType.NoWp);
            add(new Zone("수확소", 1), IconType.Wp);
            add(new Zone("오르막길", 1), IconType.NoWp);
            add(new Zone("노예 감호소", 1), IconType.Wp);
            add(new Zone("감시탑", 1), IconType.Town);
            add(new Zone("관리 구역", 1), IconType.NoWp);
            add(new Zone("오리아스 광장", 1), IconType.Wp);
            add(new Zone("템플러의 법정", 1), IconType.Wp);
            add(new Zone("결백의 방", 1), IconType.Wp);
            add(new Zone("타오르는 법정", 1), IconType.NoWp);
            add(new Zone("멸망한 광장", 1), IconType.Wp);
            add(new Zone("납골당", 1), IconType.NoWp);
            add(new Zone("성유물 보관실", 1), IconType.Wp);
            add(new Zone("대성당 옥상", 1), IconType.NoWp);
            add(kitavaPart1Kill, IconType.Wp);
            add(act6Home, IconType.Town, kitavaPart1Kill);
            add(new Zone("The Coast", 2), IconType.Wp, act6Home);
            add(new Zone("The Mud Flats", 2), IconType.NoWp, act6Home);
            add(new Zone("The Karui Fortress", 2), IconType.NoWp, act6Home);
            add(new Zone("The Ridge", 2), IconType.Wp, act6Home);
            add(new Zone("The Lower Prison", 2), IconType.Wp, act6Home);
            add(new Zone("Shavronne's Tower", 2), IconType.NoWp, act6Home);
            add(new Zone("Prisoner's Gate", 2), IconType.Wp, act6Home);
            add(new Zone("The Western Forest", 2), IconType.Wp, act6Home);
            add(new Zone("The Riverways", 2), IconType.Wp, act6Home);
            add(new Zone("The Southern Forest", 2), IconType.Wp, act6Home);
            add(new Zone("The Cavern of Anger", 2), IconType.NoWp, act6Home);
            add(new Zone("The Beacon", 2), IconType.Wp, act6Home);
            add(new Zone("The Brine King's Reef", 2), IconType.Wp, act6Home);
            add(act7Home, IconType.Town);
            add(new Zone("The Broken Bridge", 2), IconType.NoWp, act7Home);
            add(new Zone("The Crossroads", 2), IconType.Wp, act7Home);
            add(new Zone("The Fellshrine Ruins", 2), IconType.NoWp, act7Home);
            add(new Zone("The Crypt", 2), IconType.Wp, act7Home);
            add(new Zone("The Chamber of Sins Level 1", 2), IconType.Wp, act7Home);
            add(new Zone("Maligaro's Sanctum", 2), IconType.NoWp, act7Home);
            add(new Zone("The Chamber of Sins Level 2", 2), IconType.NoWp, act7Home);
            add(new Zone("The Den", 2), IconType.Wp, act7Home);
            add(new Zone("The Ashen Fields", 2), IconType.Wp, act7Home);
            add(new Zone("The Northern Forest", 2), IconType.Wp, act7Home);
            add(new Zone("The Causeway", 2), IconType.Wp, act7Home);
            add(new Zone("The Vaal City", 2), IconType.Wp, act7Home);
            add(new Zone("The Temple of Decay Level 1", 2), IconType.NoWp, act7Home);
            add(new Zone("The Temple of Decay Level 2", 2), IconType.NoWp, act7Home);
            add(sarnRamparts, IconType.Wp);
            add(act8Home, IconType.Town, sarnRamparts);
            add(new Zone("The Toxic Conduits", 2), IconType.NoWp, act8Home);
            add(new Zone("Doedre's Cesspool", 2), IconType.Wp, act8Home);
            add(new Zone("The Quay", 2), IconType.NoWp, act8Home);
            add(new Zone("The Grain Gate", 2), IconType.Wp, act8Home);
            add(new Zone("The Imperial Fields", 2), IconType.Wp, act8Home);
            add(new Zone("The Solaris Temple Level 1", 2), IconType.Wp, act8Home);
            add(new Zone("The Solaris Temple Level 2", 2), IconType.NoWp, act8Home);
            add(new Zone("The Solaris Concourse", 2), IconType.Wp, act8Home);
            add(new Zone("The Harbour Bridge", 2), IconType.NoWp, act8Home);
            add(new Zone("The Lunaris Concourse", 2), IconType.Wp, act8Home);
            add(new Zone("The Lunaris Temple Level 1", 2), IconType.Wp, act8Home);
            add(new Zone("The Lunaris Temple Level 2", 2), IconType.NoWp, act8Home);
            add(new Zone("The Bath House", 2), IconType.Wp, act8Home);
            add(bloodAqueduct, IconType.Wp);
            add(act9Home, IconType.Town, bloodAqueduct);
            add(new Zone("The Descent", 2), IconType.NoWp, act9Home);
            add(new Zone("The Vastiri Desert", 2), IconType.Wp, act9Home);
            add(new Zone("The Foothills", 2), IconType.Wp, act9Home);
            add(new Zone("The Tunnel", 2), IconType.Wp, act9Home);
            add(new Zone("The Boiling Lake", 2), IconType.NoWp, act9Home);
            add(new Zone("The Quarry", 2), IconType.Wp, act9Home);
            add(new Zone("The Refinery", 2), IconType.NoWp, act9Home);
            add(new Zone("The Belly of the Beast", 2), IconType.NoWp, act9Home);
            add(new Zone("The Rotting Core", 2), IconType.NoWp, act9Home);
            add(act10Home, IconType.Town);
            add(new Zone("The Cathedral Rooftop", 2), IconType.NoWp, act10Home);
            add(new Zone("The Ravaged Square", 2), IconType.Wp, act10Home);
            add(new Zone("The Torched Courts", 2), IconType.NoWp, act10Home);
            add(new Zone("The Desecrated Chambers", 2), IconType.Wp, act10Home);
            add(new Zone("The Reliquary", 2), IconType.Wp, act10Home);
            add(new Zone("The Canals", 2), IconType.NoWp, act10Home);
            add(new Zone("The Feeding Trough", 2), IconType.NoWp, act10Home);
            add(new Zone("Oriath", 2), IconType.Town, act10Home);
        }

        private static void add(Zone zone, IconType icon, Zone requirement = null)
        {
            ZONES.Add(zone);
            ICONTYPES[zone] = icon;
            REQUIRED[zone] = requirement;
        }

        // Creates a zone representation using the zone name.
        // Tries to guess the part using information about the encountered zones so far.
        public static IZone Parse(string zoneName, HashSet<IZone> encounteredZones)
        {
            return new Zone(zoneName, guessPart(zoneName, encounteredZones));
        }

        // Returns part 1 if the requirements for part 2 are not met. 2 otherwise.
        // Assuming the run started in act 1, if the previous zone requirements are not met for the part 2 equivalent, then we are certain that this is a part 1 zone.
        // Assuming runners don't go back to part 1 zones once in part 2, we are quite certain that this is a part 2 zone.
        // They may return to part 1 towns but returning part 2 instead would not cause more or fewer splits to occur.
        private static int guessPart(string zoneName, HashSet<IZone> encounteredZones)
        {
            Zone zone = new Zone(zoneName, 2);
            // Check to make sure that a part 2 version exists for this zone.
            if (REQUIRED.ContainsKey(zone))
            {
                Zone required = REQUIRED[zone];
                if (required == null || encounteredZones.Contains(required))
                {
                    return 2;
                }
            }
            return 1;
        }

        private string name;
        private int part;

        private Zone(string name, int part)
        {
            this.name = name;
            this.part = part;
        }

        public string Serialize()
        {
            return ToString();
        }

        public string SplitName()
        {
            if (part == 1)
            {
                return name;
            }
            return ToString();
        }

        public override string ToString()
        {
            return name + " (Part " + part + ")";
        }

        public override bool Equals(object obj)
        {
            Zone zone = obj as Zone;
            if (zone == null)
            {
                return false;
            }
            return name.Equals(zone.name) && part == zone.part;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() * 23 + part;
        }
    }
}
