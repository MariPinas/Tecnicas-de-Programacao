public class App {
    public static void main(String[] args) throws Exception {
        FornitureFactory vf = new VictorianFornitureFactory();
        Client cli = new Client();
        cli.setFactory(vf);
        Chair cadeira = cli.createChair();

        cadeira.getDescricao();

    }
}
