public class Item {

    private int weight;
    private string name;
    private int value;
    private string type;
    private string desc;
    private bool canHold;

    public Item(string name, int weight, int value, string type, string desc, bool canHold)
    {
        this.setName(name);
        this.setWeight(weight);
        this.setValue(value);
        this.setType(type);
        this.setDesc(desc);
        this.setCanHold(canHold);
    }
    public int getWeight()
    {
        return weight;
    }
    private void setWeight(int weight)
    {
        this.weight = weight;
    }
    public string getName()
    {
        return name;
    }
    private void setName(string name)
    {
        this.name = name;
    }

    public int getValue()
    {
        return value;
    }

    private void setValue(int value)
    {
        this.value = value;
    }

    public string getType()
    {
        return type;
    }

    private void setType(string type)
    {
        this.type = type;
    }

    public string getDesc()
    {
        return desc;
    }

    private void setDesc(string desc)
    {
        this.desc = desc;
    }

    public bool getCanHold()
    {
        return canHold;
    }

    private void setCanHold(bool canHold)
    {
        this.canHold = canHold;
    }
}
