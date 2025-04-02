public class NormalFornitureFactory implements FornitureFactory{
    
    @Override
    public Chair createChair(){
        return new NormalChair();
    }
}
