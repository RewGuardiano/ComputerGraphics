using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    internal List<Vector3Int> faces;
    List<Vector3Int> texture_index_list;
    internal List<Vector3> vertices;
    List<Vector2> texture_coordinates;
    List<Vector3> normals;

    public Model()
    {
        vertices = new List<Vector3>();
        addvertices();
        faces = new List<Vector3Int>();
        addFaces();

    }

    private void addFaces()
    {
        faces.Add(new Vector3Int(1, 8, 10));
        faces.Add(new Vector3Int(1, 10, 13));
        faces.Add(new Vector3Int(1, 13, 12));
        faces.Add(new Vector3Int(1, 12, 2));
        faces.Add(new Vector3Int(2, 12, 3));
        faces.Add(new Vector3Int(3, 12, 4));
        faces.Add(new Vector3Int(4, 14, 15));
        faces.Add(new Vector3Int(4, 15, 5));
        faces.Add(new Vector3Int(5, 13, 6));
        faces.Add(new Vector3Int(5, 15, 6));
        faces.Add(new Vector3Int(6, 13, 11));
        faces.Add(new Vector3Int(11, 13, 10));
        faces.Add(new Vector3Int(6, 11, 7));
        faces.Add(new Vector3Int(7, 11, 0));
        faces.Add(new Vector3Int(0, 11, 9));


        faces.Add(new Vector3Int(1, 18, 17));
        faces.Add(new Vector3Int(1, 2, 18));
        faces.Add(new Vector3Int(2, 3, 19));
        faces.Add(new Vector3Int(2, 19, 18));
        faces.Add(new Vector3Int(3, 4, 20));
        faces.Add(new Vector3Int(3, 20, 19));
        faces.Add(new Vector3Int(4, 5, 21));
        faces.Add(new Vector3Int(4, 21, 20));
        faces.Add(new Vector3Int(5, 6, 22));
        faces.Add(new Vector3Int(5, 22, 21));
        faces.Add(new Vector3Int(6, 7, 23));
        faces.Add(new Vector3Int(6, 23, 22));
        faces.Add(new Vector3Int(0, 16, 23));
        faces.Add(new Vector3Int(0, 23, 7));
        faces.Add(new Vector3Int(0, 9, 24));
        faces.Add(new Vector3Int(0, 24, 16));
        faces.Add(new Vector3Int(1, 17, 25));
        faces.Add(new Vector3Int(1, 25, 8));
        faces.Add(new Vector3Int(8, 25, 27));
        faces.Add(new Vector3Int(8, 27, 10));
        faces.Add(new Vector3Int(9, 11, 26));
        faces.Add(new Vector3Int(9, 26, 24));
        faces.Add(new Vector3Int(10, 27, 26));
        faces.Add(new Vector3Int(10, 26, 11));
        faces.Add(new Vector3Int(12, 13, 31));
        faces.Add(new Vector3Int(12, 31, 29));
        faces.Add(new Vector3Int(14, 28, 30));
        faces.Add(new Vector3Int(14, 30, 15));
        faces.Add(new Vector3Int(12, 29, 28));
        faces.Add(new Vector3Int(12, 28, 14));
        faces.Add(new Vector3Int(13, 15, 30));
        faces.Add(new Vector3Int(13, 30, 31));

        faces.Add(new Vector3Int(16, 24, 26));
        faces.Add(new Vector3Int(16, 26, 23));
        faces.Add(new Vector3Int(22, 23, 26));
        faces.Add(new Vector3Int(17, 27, 25));
        faces.Add(new Vector3Int(17, 31, 27));
        faces.Add(new Vector3Int(17, 18, 29));
        faces.Add(new Vector3Int(26, 31, 22));
        faces.Add(new Vector3Int(26, 27, 31));
        faces.Add(new Vector3Int(17, 29, 31));
        faces.Add(new Vector3Int(18, 19, 29));
        faces.Add(new Vector3Int(19, 20, 29));
        faces.Add(new Vector3Int(20, 30, 28));
        faces.Add(new Vector3Int(20, 21, 30));
        faces.Add(new Vector3Int(21, 22, 31));

    }

    private void addvertices()
    {
        vertices.Add(new Vector3(3, -5, 1));// 0 
        vertices.Add(new Vector3(-3, -5, 1));// 1
        vertices.Add(new Vector3(-3, 5, 1));// 2
        vertices.Add(new Vector3(2, 5, 1));// 3
        vertices.Add(new Vector3(3, 4, 1));// 4 
        vertices.Add(new Vector3(3, 1, 1));// 5
        vertices.Add(new Vector3(2, 0, 1));// 6 
        vertices.Add(new Vector3(3, -1, 1));// 7
        vertices.Add(new Vector3(-1, -5, 1));// 8 
        vertices.Add(new Vector3(1, -5, 1));// 9
        vertices.Add(new Vector3(-1, -1, 1));// 10 
        vertices.Add(new Vector3(1, -1, 1));// 11
        vertices.Add(new Vector3(-2, 4, 1));// 12
        vertices.Add(new Vector3(-2, 1, 1));// 13
        vertices.Add(new Vector3(2, 4, 1));// 14
        vertices.Add(new Vector3(2, 1, 1));// 15
        vertices.Add(new Vector3(3, -5, 2));// 16
        vertices.Add(new Vector3(-3, -5, 2));// 17
        vertices.Add(new Vector3(-3, 5, 2));// 18
        vertices.Add(new Vector3(2, 5, 2));// 19
        vertices.Add(new Vector3(3, 4, 2));// 20
        vertices.Add(new Vector3(3, 1, 2));// 21
        vertices.Add(new Vector3(2, 0, 2));// 22
        vertices.Add(new Vector3(3, -1, 2));// 23
        vertices.Add(new Vector3(1, -5, 2));// 24 
        vertices.Add(new Vector3(-1, -5, 2));// 25
        vertices.Add(new Vector3(1, -1, 2));// 26 
        vertices.Add(new Vector3(-1, -1, 2));// 27
        vertices.Add(new Vector3(2, 4, 2));// 28
        vertices.Add(new Vector3(-2, 4, 2));// 29
        vertices.Add(new Vector3(2, 1, 2));// 30
        vertices.Add(new Vector3(-2, 1, 2));// 31

    }




    public GameObject CreateUnityGameObject()
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();

        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        /*List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normalz = new List<Vector3>();*/

        for (int i = 0; i < faces.Count; i++)
        {
            //Vector3 normal_for_face = normals[i];

            //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

            coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        /*mesh.uv = text_coords.ToArray();
        mesh.normals = normalz.ToArray();*/
        mesh_filter.mesh = mesh;

        return newGO;
    }

}
