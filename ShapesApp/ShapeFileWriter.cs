using ShapesApp.Models;

namespace ShapesApp;

public class ShapeFileWriter
{
    private FileStream _fileStream;
    private StreamWriter _writer;

    public ShapeFileWriter(string path)
    {
        _fileStream = new FileStream(path, FileMode.Create);
        _writer = new StreamWriter(_fileStream);
    }

    public void Write(Shape shape)
    {
        _writer.WriteLine(shape.ToString());
    }
}
