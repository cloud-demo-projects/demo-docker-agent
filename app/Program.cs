using System;
using k8s;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Load from the default kubeconfig on the machine.
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

            // Load from a specific file:
            //var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(Environment.GetEnvironmentVariable("KUBECONFIG"));

            // Load from in-cluster configuration:
            //var config = KubernetesClientConfiguration.InClusterConfig();

            // Use the config object to create a client.
            var client = new Kubernetes(config);

            var namespaces = client.ListNamespace();
            foreach (var ns in namespaces.Items) {
                Console.WriteLine(ns.Metadata.Name);
                var list = client.ListNamespacedPod(ns.Metadata.Name);
                foreach (var item in list.Items)
                {
                    Console.WriteLine(item.Metadata.Name);
                }
            }

        }
    }
}
