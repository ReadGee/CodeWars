import org.junit.*;

public class MorseCodeDecoderTest {
    @Test
    public void HeyJude()
    {
        MorseCodeDecoder testClass = new MorseCodeDecoder();
        Assert.assertEquals("HEY JUDE", testClass.decode(".... . -.--   .--- ..- -.. ."));
    }

    @Test
    public void SOS()
    {
        MorseCodeDecoder testClass = new MorseCodeDecoder();
        Assert.assertEquals("SOS", testClass.decode("...---..."));
    }

    @Test
    public void E_E()
    {
        MorseCodeDecoder testClass = new MorseCodeDecoder();
        Assert.assertEquals("E E", testClass.decode("   .   ."));
    }
}
