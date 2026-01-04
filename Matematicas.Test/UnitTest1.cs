using Xunit;

public class MatematicasTests
{
    [Fact]
    public void EsPerfecto_6_RetornaTrue()
    {
        var m = new Matematicas();
        Assert.True(m.EsPerfecto(6)); // 6 es perfecto
    }

    [Fact]
    public void EsPerfecto_8_RetornaFalse()
    {
        var m = new Matematicas();
        Assert.False(m.EsPerfecto(8)); // 8 no es perfecto
    }
}
