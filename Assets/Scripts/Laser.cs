using UnityEngine;

public class Laser : Gun
{
    override protected void Update()
    {
        base.Update();
        if (Input.GetMouseButtonDown(0) && (Time.time - lastFireTime) > fireRate)
        {
            lastFireTime = Time.time;
            Fire();
        }
    }
}
