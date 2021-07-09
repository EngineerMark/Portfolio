using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectManager : MonoBehaviour
{
    public Project[] Projects;
    public GameObject ProjectParent;
    public ProjectTile ProjectPrefab;

    private void Start()
    {
        foreach (Project project in Projects)
        {
            GameObject prefabClone = Instantiate(ProjectPrefab.gameObject);
            ProjectTile tileInfo = prefabClone.GetComponent<ProjectTile>();
            Button tileButton = prefabClone.GetComponent<Button>();

            tileButton.onClick.AddListener(() =>
            {
                project.OnClick?.Invoke();
            });

            tileInfo.Thumbnail.sprite = project.Thumbnail;
            tileInfo.ProjectTitle.text = project.Title;
            tileInfo.ProjectDescription.text = project.Description;
            tileInfo.ProjectType.text = project.Type.ToUpper();
            tileInfo.ProjectCompany.text = project.Company;

            prefabClone.transform.SetParent(ProjectParent.transform);
            prefabClone.transform.localScale = Vector3.one;
        }
    }

    public void OpenURL(string url){
        Application.OpenURL(url);
    }
}
