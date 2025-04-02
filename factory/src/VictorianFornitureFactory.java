public class VictorianFornitureFactory implements FornitureFactory{

    @Override
    public Chair createChair(){
        return new VictorianChair();
    }
}
