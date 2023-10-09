using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class GraphicsPipeline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Model myModel = new Model();
        List<Vector4> verts = convertToHomg(myModel.vertices);

        Vector3 axis = (new Vector3(17, 0, 0)).normalized;
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(Vector3.zero, Quaternion.AngleAxis(-31, axis), Vector3.one);

        DisplayMatrix(rotationMatrix);

        List<Vector4> imageAfterRotation = ApplyTransformation(verts, rotationMatrix);

        SaveVector4ToFile(imageAfterRotation, "imageAfterRotation.txt");

        Matrix4x4 ScaleMatrix = Matrix4x4.TRS(new Vector3(2, 3, 4), Quaternion.identity, Vector3.one);

        DisplayMatrix(ScaleMatrix);

        List<Vector4> imageAfterScaling = ApplyTransformation(imageAfterRotation, ScaleMatrix);

        SaveVector4ToFile(imageAfterScaling, "imageAfterScale.txt");

        Matrix4x4 translationMatrix = Matrix4x4.TRS(new Vector3(4, -4, 1), Quaternion.identity, Vector3.one);

        DisplayMatrix(translationMatrix);

        List<Vector4> imageAfterTranslation = ApplyTransformation(imageAfterScaling, translationMatrix);

        SaveVector4ToFile(imageAfterTranslation, "imageAfterTranslation.txt");

        SaveMatrixToFile(rotationMatrix, "rotationMatrix.txt");
        SaveMatrixToFile(ScaleMatrix, "scaleMatrix.txt");
        SaveMatrixToFile(translationMatrix, "translationMatrix.txt");

        Matrix4x4 SingleMatrixOfTransformation = translationMatrix * ScaleMatrix * rotationMatrix;

        DisplayMatrix(SingleMatrixOfTransformation);

        SaveMatrixToFile(SingleMatrixOfTransformation, "singleMatrixOfTransformations.txt");
        List<Vector4> imageAfterSingleMatrixOfTransformation = ApplyTransformation(verts, SingleMatrixOfTransformation);

        SaveVector4ToFile(imageAfterSingleMatrixOfTransformation, "imageAfterSingleMatrixOfTransformation.txt");

        Matrix4x4 viewingMatrix = Matrix4x4.LookAt(new Vector3(5, 0, 2),new Vector3(2,1,0).normalized, Vector3.up);

        DisplayMatrix(viewingMatrix);

        SaveMatrixToFile(viewingMatrix, "ViewingMatrix.Txt");

        List<Vector4> imageAfterViewMatrix = ApplyTransformation(imageAfterTranslation, viewingMatrix);

        SaveVector4ToFile(imageAfterViewMatrix, "imageAfterViewingMatrix.txt");

        float fieldOfView = 90f;
        float aspectRatio = Screen.width / Screen.height;

        Matrix4x4 projectionMatrix = Matrix4x4.Perspective(fieldOfView, aspectRatio, 1, 1000);

        DisplayMatrix(projectionMatrix);

        SaveMatrixToFile(projectionMatrix, "projectionMatrix.txt");

        List<Vector4> imageAfterProjectionMatrix = ApplyTransformation(imageAfterViewMatrix, projectionMatrix);

        SaveVector4ToFile(imageAfterProjectionMatrix, "imageAfterProjectionMatrix.txt");


        //SingleMatrix For everything 
        Matrix4x4 SingleMatrixForEverything = projectionMatrix * viewingMatrix * SingleMatrixOfTransformation;

        DisplayMatrix(SingleMatrixForEverything);

        SaveMatrixToFile(SingleMatrixForEverything, "SingleMatrixForEverything.txt");

        List<Vector4> imageAfterSingleMatrixForEverything = ApplyTransformation(verts, SingleMatrixForEverything);

        SaveVector4ToFile(imageAfterSingleMatrixForEverything, "imageAfterSingleMatrixForEverything.txt");
        


    }




    private List<Vector4> convertToHomg(List<Vector3> vertices)
    {
        List<Vector4> output = new List<Vector4>();
        foreach (Vector3 v in vertices)
        {
            output.Add(new Vector4(v.x, v.y, v.z, 1.0f));//Converting vector3 to homog Vector 4 points 
        }
        return output;
    }

    private List<Vector4> ApplyTransformation(List<Vector4> verts, Matrix4x4 transformMatrix)
    {
        List<Vector4> output = new List<Vector4>();
        foreach (Vector4 v in verts)
        {
            output.Add(transformMatrix * v);

        }
        return output;
    }

    private void DisplayMatrix(Matrix4x4 rotationMatrix)
    {
        for (int i = 0; i < 4; i++)
        {
            print(rotationMatrix.GetRow(i));
        }

    }

    private void SaveMatrixToFile(Matrix4x4 matrix, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < 4; i++)
            {
                Vector4 row = matrix.GetRow(i);
                writer.WriteLine($"{row.x},{row.y},{row.z},{row.w}");
            }
        }
    }

    private void SaveVector4ToFile(List<Vector4> vectorlist, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Vector4 vector in vectorlist)
            {
                writer.WriteLine($"{vector.x},{vector.y},{vector.z},{vector.w}");
            }
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
