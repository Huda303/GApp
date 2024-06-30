using System.Text.Json;
namespace LinkedList{
    // الكومت عبارة عن نود يحتويعلى مسج تحتوي كل التغييرات ونحصل عليها من اليوزر
    // AddEnd تتم اضافة كل كومت عن طريق دالة الاضافة بالنهاية 
    // ونعرضه من الملف JSON يتم حفظ الناتج في ملف 
    /*##############################################################################*/
public class Commit
{
    public string Massage { get; set; }
    public Commit next { get; set; }
    public Commit Prev { get; set; }

    public Commit(string massage)
    {
        this.Massage = massage;
        this.next = null;
        this.Prev = null;
    }
}
/// /////////////////////////////////////

    public class CommitHistory
    {
    private Commit head;
    private Commit tail;

    public CommitHistory()
    {
        this.head = null;
        this.tail = null;
    }
// begening of the add function
public void AddCommit(string message)
    {
        Commit newCommit = new Commit(message);
        if (head == null)
        {
            head = newCommit;
            tail = newCommit;
        }
        else
        {
            tail.next = newCommit;
            newCommit.Prev = tail;
            tail = newCommit;
        }
    }
// end add function

// begening of the display function
public void Display()
    {
        Commit current = head;
        while (current != null)
        {
            Console.WriteLine(current.Massage);
            current = current.next;
        }
    }
// end of display
}
}

