using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform launchPoint;

    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, projectilePrefab.transform.rotation);
        Vector3 originalScale = projectile.transform.localScale;
        projectile.transform.localScale = new Vector3(
            originalScale.x * transform.localScale.x > 0 ? 1 : -1, 
            originalScale.y, 
            originalScale.z
            );
    }
}
