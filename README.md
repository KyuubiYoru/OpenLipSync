# OpenLipSync

**Experimental work-in-progress project**

An open-source, cross-platform project that converts audio input into realistic facial expressions in real-time following the [MPEG-4 (FBA)](https://visagetechnologies.com/uploads/2012/08/MPEG-4FBAOverview.pdf) standard.


## Setup for model training

Core (uv)

```bash
uv sync
```

MFA (micromamba)

```bash
micromamba create -n mfa -c conda-forge python=3.12 montreal-forced-aligner
micromamba activate mfa

mfa model download acoustic english_us_arpa
mfa model download dictionary english_us_arpa
mfa model download g2p english_us_arpa
```

Other dependencies needed before training:
```bash
pip install torch
micromamba install -c pytorch torchaudio numpy scikit-learn tqdm tensorboard matplotlib
```

Dataset Download is now integrated in the training script.

```python training/train.py --config training/recipes/tcn_config.toml```


This project uses the [LibriSpeech ASR corpus](https://openslr.org/12/) (CC BY 4.0 license).
