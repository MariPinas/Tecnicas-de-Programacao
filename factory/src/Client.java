public class Client {
    FornitureFactory fabrica;

    public void setFactory(FornitureFactory fabrica){
        this.fabrica = fabrica;
    }

    public Chair createChair(){
        return fabrica.createChair();
    }
}
