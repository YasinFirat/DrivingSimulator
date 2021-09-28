using UnityEngine;

[System.Serializable]   //Sınıfı inspector panelinde değişken olarak gösterilmesini sağlar
public struct Wheels
{ //struct sınıfı, class sınıfına göre daha optimize olduğundan tercih ettim.
    [Tooltip("Sağ tekeri sürükle")]
    public Transform right;
    [Tooltip("Sol tekeri sürükle")]
    public Transform left;
    [Tooltip("Tekerin Max dönme açısı")]
    public float maxAngle;
    private float angle;
    
    public Wheels SetAngle(float angle)
    {
        this.angle = angle;
        return this; //Wheels sınıfını tekrar çağırır.
    }
    public Wheels TurnRight()
    {
        right.localRotation = Quaternion.Euler(0,maxAngle* angle, 0);
        return this;//Wheels sınıfını tekrar çağırır.
    } 
    public Wheels TurnLeft()
    {
        left.localRotation = Quaternion.Euler(0,maxAngle* angle, 0);
        return this;//Wheels sınıfını tekrar çağırır.
    }

}
