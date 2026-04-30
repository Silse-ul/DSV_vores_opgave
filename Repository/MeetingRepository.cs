using dsv_mini.Meetingroom;

namespace dsv_mini.Repository;

public class MeetingRepository :IMeetingRepository
{
    private List<Meeting> _meetingList;

    public MeetingRepository()
    {
        //tom liste 
        _meetingList = new List<Meeting>();
        // vi tilføjer lokaler her 
        Meeting m = new Meeting("Mødelokale 1", 7, "36b",
            "Kapacitet: 7 personer, Udstyr: Projektor, Whiteboard, Videokonferenceudstyr. Beskrivelse: Et mellemstort mødelokale som ofte bruges til teammøder eller online møder med andre kontorer.", "image/imageRoom1/Modelokale-Vilhelm-Lauritzen-1-1920x896.jpg");
        _meetingList.Add(m);
        Meeting a = new Meeting("Mødelokale 2", 20, "88y", "Kapacitet: 20 personer Udstyr: Projektor, Lydanlæg, Whiteboard, Mikrofon. Beskrivelse: Et stort mødelokale til workshops, præsentationer eller større møder.","image/imageRoom2/moedelokale-med-bogo-hoejttalere-og-skaerm-ved-langt-moedebord.jpg");
        _meetingList.Add(a);
        Meeting g = new Meeting("Mødelokale 3", 12, "76h",
            "Kapacitet: 12 personer, Udstyr: Stor skærm, Videokonferencekamera, Whiteboard, HDMI og USB-C tilslutning. Beskrivelse: Et større mødelokale der bruges til præsentationer og møder mellem flere afdelinger.","image/imageRoom3/content.jpeg");
        _meetingList.Add(g);
        Meeting p = new Meeting("Mødelokale 4", 4, "15e",
            "Kapacitet: 4 personer. Udstyr: Whiteboard, TV-skærm, HDMI-tilslutning. Beskrivelse: Et lille mødelokale der er velegnet til korte møder eller 1-1 samtaler.", "image/imageRoom4/4-ppl.jpeg");
        _meetingList.Add(p);

    }

    public List<Meeting> GetAll()
    {
        return _meetingList;
        
    }


    public Meeting GetById(int id)
    {
        foreach (Meeting item in _meetingList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }

    
}